﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Logging.V2;
using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ErrorReportingOptionsTest
    {
        private const string _projectId = "pid";
        private static readonly LoggingServiceV2Client _loggingClient = new Mock<LoggingServiceV2Client>().Object;


        [Fact]
        public void CreateConsumer_ErrorToLogsConsumer()
        {
            var eventTarget = EventTarget.ForLogging(_projectId, "test-log", _loggingClient);
            var options = ErrorReportingOptions.Create(eventTarget);
            var consumer = options.CreateConsumer();
            Assert.IsType<RpcRetryConsumer<LogEntry>>(consumer);
            var retryConsumer = (RpcRetryConsumer<LogEntry>) consumer;
            Assert.IsType<GrpcLogConsumer>(retryConsumer._consumer);
        }

        [Fact]
        public void CreateConsumer_BufferedConsumer()
        {
            var bufferOptions = BufferOptions.SizedBuffer();
            var eventTarget = EventTarget.ForLogging(_projectId, "test-log", _loggingClient);
            var options = ErrorReportingOptions.Create(eventTarget, bufferOptions);
            var consumer = options.CreateConsumer();
            Assert.IsType<SizedBufferingConsumer<LogEntry>>(consumer);
        }
    }
}
