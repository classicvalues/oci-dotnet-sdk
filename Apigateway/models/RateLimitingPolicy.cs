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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Limit the number of requests that should be handled for the specified window using a specfic key.
    /// </summary>
    public class RateLimitingPolicy 
    {
        
        /// <value>
        /// The maximum number of requests per second to allow.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RateInRequestsPerSecond is required.")]
        [JsonProperty(PropertyName = "rateInRequestsPerSecond")]
        public System.Nullable<int> RateInRequestsPerSecond { get; set; }
                ///
        /// <value>
        /// The key used to group requests together.
        /// </value>
        ///
        public enum RateKeyEnum {
            [EnumMember(Value = "CLIENT_IP")]
            ClientIp,
            [EnumMember(Value = "TOTAL")]
            Total
        };

        /// <value>
        /// The key used to group requests together.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RateKey is required.")]
        [JsonProperty(PropertyName = "rateKey")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RateKeyEnum> RateKey { get; set; }
        
    }
}
