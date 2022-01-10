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


namespace Oci.WafService.Models
{
    /// <summary>
    /// Rate limiting configuration.
    /// </summary>
    public class RequestRateLimitingConfiguration 
    {
        
        /// <value>
        /// Evaluation period in seconds.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeriodInSeconds is required.")]
        [JsonProperty(PropertyName = "periodInSeconds")]
        public System.Nullable<int> PeriodInSeconds { get; set; }
        
        /// <value>
        /// Requests allowed per evaluation period.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestsLimit is required.")]
        [JsonProperty(PropertyName = "requestsLimit")]
        public System.Nullable<int> RequestsLimit { get; set; }
        
        /// <value>
        /// Duration of block action application in seconds when `requestsLimit` is reached. Optional and can be 0 (no block duration).
        /// </value>
        [JsonProperty(PropertyName = "actionDurationInSeconds")]
        public System.Nullable<int> ActionDurationInSeconds { get; set; }
        
    }
}
