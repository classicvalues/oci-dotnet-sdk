/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DtsService.Models
{
    
    public class UpdateTransferPackageDetails 
    {
        
        [JsonProperty(PropertyName = "originalPackageDeliveryTrackingNumber")]
        public string OriginalPackageDeliveryTrackingNumber { get; set; }
        
        [JsonProperty(PropertyName = "returnPackageDeliveryTrackingNumber")]
        public string ReturnPackageDeliveryTrackingNumber { get; set; }
        
        [JsonProperty(PropertyName = "packageDeliveryVendor")]
        public string PackageDeliveryVendor { get; set; }
                ///
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "SHIPPING")]
            Shipping,
            [EnumMember(Value = "CANCELLED")]
            Cancelled
        };

        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
