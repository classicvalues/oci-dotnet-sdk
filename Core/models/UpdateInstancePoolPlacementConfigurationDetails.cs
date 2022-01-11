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
    /// The location for where an instance pool will place instances.
    /// </summary>
    public class UpdateInstancePoolPlacementConfigurationDetails 
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
        /// The fault domains to place instances.
        /// <br/>
        /// If you don't provide any values, the system makes a best effort to distribute
        /// instances across all fault domains based on capacity.
        /// <br/>
        /// To distribute the instances evenly across selected fault domains, provide a
        /// set of fault domains. For example, you might want instances to be evenly
        /// distributed if your applications require high availability.
        /// <br/>
        /// To get a list of fault domains, use the
        /// {@link #listFaultDomains(ListFaultDomainsRequest) listFaultDomains} operation
        /// in the Identity and Access Management Service API.
        /// <br/>
        /// Example: [FAULT-DOMAIN-1, FAULT-DOMAIN-2, FAULT-DOMAIN-3]
        /// </value>
        [JsonProperty(PropertyName = "faultDomains")]
        public System.Collections.Generic.List<string> FaultDomains { get; set; }
        
        /// <value>
        /// The OCID of the primary subnet to place instances.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrimarySubnetId is required.")]
        [JsonProperty(PropertyName = "primarySubnetId")]
        public string PrimarySubnetId { get; set; }
        
        /// <value>
        /// The set of subnet OCIDs for secondary VNICs for instances in the pool.
        /// </value>
        [JsonProperty(PropertyName = "secondaryVnicSubnets")]
        public System.Collections.Generic.List<InstancePoolPlacementSecondaryVnicSubnet> SecondaryVnicSubnets { get; set; }
        
    }
}
