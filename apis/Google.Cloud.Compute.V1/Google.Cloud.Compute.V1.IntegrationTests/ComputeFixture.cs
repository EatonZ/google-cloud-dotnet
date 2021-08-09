﻿// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Compute.V1.IntegrationTests
{
    [CollectionDefinition(nameof(ComputeFixture))]
    public class ComputeFixture : CloudProjectFixtureBase, ICollectionFixture<ComputeFixture>
    {
        // Note: this would more naturally be called COMPUTE_TEST_REGION, but this
        // environment variable already exists for App Engine testing, so it's handy to
        // avoid requiring another one.
        private const string TestRegionEnvironmentVariable = "TEST_PROJECT_LOCATION";

        /// <summary>
        /// Region to use for testing.
        /// </summary>
        public string Region { get; }

        public string Zone { get; }

        /// <summary>
        /// The prefix to use for resources generated by this test fixture, so they can be cleaned up.
        /// </summary>
        public string ResourcePrefix { get; }

        public ComputeFixture()
        {
            Region = Environment.GetEnvironmentVariable(TestRegionEnvironmentVariable);
            Zone = "us-central1-a";
            if (string.IsNullOrEmpty(Region))
            {
                throw new InvalidOperationException($"Environment variable {TestRegionEnvironmentVariable} must be set");
            }
            ResourcePrefix = IdGenerator.FromDateTime(prefix: "test-", suffix: "-");
        }

        public string GenerateResourceId() => IdGenerator.FromGuid(prefix: ResourcePrefix);

        public override void Dispose()
        {
            // One method per resource type to clean
            CleanUpAddresses();
            CleanUpInstances();
        }

        private void CleanUpAddresses()
        {
            // Note: this currently assumes that all the generated addresses will be in the first
            // page of results. When pagination is properly implemented, we'll be able to foreach over
            // all addresses easily.
            var client = AddressesClient.Create();
            var list = client.List(ProjectId, Region);
            var fixtureAddresses = list
                .Select(addr => addr.Name)
                .Where(name => name.StartsWith(ResourcePrefix));

            // Note: we don't wait for the operations to complete... if they've failed once, they're likely
            // to fail again anyway.
            foreach (var addressToDelete in fixtureAddresses)
            {
                client.Delete(ProjectId, Region, addressToDelete);
            }
        }

        private void CleanUpInstances()
        {
            var client = InstancesClient.Create();
            var list = client.List(ProjectId, Zone);
            var fixtureInstances = list
                .Select(instance => instance.Name)
                .Where(name => name.StartsWith(ResourcePrefix));
            foreach (var instanceToDelete in fixtureInstances)
            {
                client.Delete(ProjectId, Zone, instanceToDelete);
            }
        }

        // Note: we could extract the region/zone from the operation, but it's a URL rather than just the region/zone part.
        // So instead, we just use the fixture's region/zone. If we want to generalize this into a helper method in the
        // library itself, we'll need to parse those URLs (or maybe the self-link, which would contain the project ID).

        public Operation PollUntilCompleted(Operation operation, string alias, ITestOutputHelper output)
        {
            var poller = CreatePoller(operation);

            TimeSpan timeOut = TimeSpan.FromMinutes(3);
            TimeSpan pollInterval = TimeSpan.FromSeconds(15);

            DateTime deadline = DateTime.UtcNow + timeOut;
            while (operation.Status != Operation.Types.Status.Done)
            {                
                output.WriteLine($"Checking for {alias} operation status ...");
                operation = poller();

                if (operation.Status == Operation.Types.Status.Done)
                {
                    break;
                }

                if (DateTime.UtcNow > deadline)
                {
                    throw new InvalidOperationException(
                        $"Timeout hit while polling for the status of the {alias} operation\n{operation}");
                }

                output.WriteLine($"Status: {operation.Status}. Sleeping for the {pollInterval.TotalSeconds}s");
                Thread.Sleep(pollInterval);
            }
            return operation;
        }

        private Func<Operation> CreatePoller(Operation operation)
        {
            if (operation.HasRegion && !operation.HasZone)
            {
                RegionOperationsClient client = RegionOperationsClient.Create();
                GetRegionOperationRequest request = new GetRegionOperationRequest
                {
                    Operation = operation.Name,
                    Region = Region,
                    Project = ProjectId,
                };
                return () => client.Get(request);
            }
            else if (operation.HasZone && !operation.HasRegion)
            {
                ZoneOperationsClient client = ZoneOperationsClient.Create();
                GetZoneOperationRequest request = new GetZoneOperationRequest
                {
                    Operation = operation.Name,
                    Zone = Zone,
                    Project = ProjectId,
                };
                return () => client.Get(request);
            }
            else if (!operation.HasZone && !operation.HasRegion)
            {
                GlobalOperationsClient client = GlobalOperationsClient.Create();
                GetGlobalOperationRequest request = new GetGlobalOperationRequest
                {
                    Operation = operation.Name,
                    Project = ProjectId,
                };
                return () => client.Get(request);
            }
            throw new ArgumentException($"Unable to determine operation type for {operation}");
        }
    }
}
