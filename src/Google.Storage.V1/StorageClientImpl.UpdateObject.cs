﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Rest;
using Google.Apis.Storage.v1;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override Object UpdateObject(
            Object obj,
            UpdateObjectOptions options = null)
            => CreateUpdateObjectRequest(obj, options).Execute();

        /// <inheritdoc />
        public override Task<Object> UpdateObjectAsync(
            Object obj,
            UpdateObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
            => CreateUpdateObjectRequest(obj, options).ExecuteAsync(cancellationToken);

        private ObjectsResource.UpdateRequest CreateUpdateObjectRequest(Object obj, UpdateObjectOptions options)
        {
            GaxRestPreconditions.CheckNotNull(obj, nameof(obj));
            GaxRestPreconditions.CheckArgument(obj.Bucket != null, nameof(obj), "The Bucket property of the object to update is null");
            GaxRestPreconditions.CheckArgument(obj.Name != null, nameof(obj), "The Name property of the object to update is null");
            GaxRestPreconditions.CheckArgument(obj.Acl != null, nameof(obj), "The Acl property of the object to update is null");
            var request = Service.Objects.Update(obj, obj.Bucket, obj.Name);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
