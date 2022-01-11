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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The configuration details to update load balancer to a different shape.
    /// 
    /// </summary>
    public class ShapeDetails 
    {
        
        /// <value>
        /// Bandwidth in Mbps that determines the total pre-provisioned bandwidth (ingress plus egress).
        /// The values must be between 10 and the maximumBandwidthInMbps.
        /// <br/>
        /// Example: 150
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinimumBandwidthInMbps is required.")]
        [JsonProperty(PropertyName = "minimumBandwidthInMbps")]
        public System.Nullable<int> MinimumBandwidthInMbps { get; set; }
        
        /// <value>
        /// Bandwidth in Mbps that determines the maximum bandwidth (ingress plus egress) that the load balancer can
        /// achieve. This bandwidth cannot be always guaranteed. For a guaranteed bandwidth use the minimumBandwidthInMbps
        /// parameter.
        /// <br/>
        /// The values must be between minimumBandwidthInMbps and 8192 (8Gbps).
        /// <br/>
        /// Example: 1500
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaximumBandwidthInMbps is required.")]
        [JsonProperty(PropertyName = "maximumBandwidthInMbps")]
        public System.Nullable<int> MaximumBandwidthInMbps { get; set; }
        
    }
}
