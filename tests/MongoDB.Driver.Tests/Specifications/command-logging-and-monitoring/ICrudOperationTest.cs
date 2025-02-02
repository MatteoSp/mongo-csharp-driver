/* Copyright 2010-present MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Threading.Tasks;
using FluentAssertions;
using MongoDB.Bson;
using MongoDB.Driver.Core.Clusters;
using MongoDB.Driver.Core.Misc;

namespace MongoDB.Driver.Tests.Specifications.command_logging_and_monitoring
{
    public interface ICrudOperationTest
    {
        bool CanExecute(ClusterDescription clusterDescription, BsonDocument arguments, out string reason);

        void Execute(ClusterDescription clusterDescription, IMongoDatabase database, IMongoCollection<BsonDocument> collection, BsonDocument arguments, bool async);

        BsonDocument MassageReply(BsonDocument reply);
    }
}
