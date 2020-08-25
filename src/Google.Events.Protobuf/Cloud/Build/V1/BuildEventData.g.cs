// Copyright 2020, Google LLC
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

namespace Google.Events.Protobuf.Cloud.Build.V1
{    
    [CloudEventDataConverter(typeof(ProtobufCloudEventDataConverter<BuildEventData>))]
    public partial class BuildEventData
    {
        /// <summary>CloudEvent type for the 'statusChanged' event.</summary>
        public const string StatusChangedCloudEventType = "google.cloud.cloudbuild.build.v1.statusChanged";

    }
}
