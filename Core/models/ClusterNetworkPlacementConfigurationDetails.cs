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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The location for where the instance pools in a cluster network will place instances.
    /// </summary>
    public class ClusterNetworkPlacementConfigurationDetails 
    {
        
        /// <value>
        /// The availability domain to place instances.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the primary subnet to place
        /// instances.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrimarySubnetId is required.")]
        [JsonProperty(PropertyName = "primarySubnetId")]
        public string PrimarySubnetId { get; set; }
        
        /// <value>
        /// The set of secondary VNIC data for instances in the pool.
        /// </value>
        [JsonProperty(PropertyName = "secondaryVnicSubnets")]
        public System.Collections.Generic.List<InstancePoolPlacementSecondaryVnicSubnet> SecondaryVnicSubnets { get; set; }
        
    }
}
