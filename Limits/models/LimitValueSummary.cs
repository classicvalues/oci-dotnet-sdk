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


namespace Oci.LimitsService.Models
{
    /// <summary>
    /// The value of a specific resource limit.
    /// </summary>
    public class LimitValueSummary 
    {
        
        /// <value>
        /// The resource limit name. To be used for writing policies (in case of quotas) or other programmatic calls.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The scope type of the limit.
        /// 
        /// </value>
        ///
        public enum ScopeTypeEnum {
            [EnumMember(Value = "GLOBAL")]
            Global,
            [EnumMember(Value = "REGION")]
            Region,
            [EnumMember(Value = "AD")]
            Ad
        };

        /// <value>
        /// The scope type of the limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scopeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScopeTypeEnum> ScopeType { get; set; }
        
        /// <value>
        /// If present, the returned value is only specific to this availability domain.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The resource limit value.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public System.Nullable<long> Value { get; set; }
        
    }
}
