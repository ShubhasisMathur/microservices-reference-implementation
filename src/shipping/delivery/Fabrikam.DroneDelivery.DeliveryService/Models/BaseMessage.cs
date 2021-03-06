// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using Newtonsoft.Json;

namespace Fabrikam.DroneDelivery.DeliveryService.Models
{
    public class BaseMessage
    {
        [JsonProperty(PropertyName = "partitionKey")]
        public string PartitionKey { get; set; }
        public string MessageType { get; set; }

    }
}
