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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// The body for defining a new resolver VNIC endpoint. Either isForwarding or isListening must be true, but not both.
    /// If isListening is true, a listeningAddress may be provided. If isForwarding is true, a forwardingAddress
    /// may be provided. When not provided, an address will be chosen automatically.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class CreateResolverVnicEndpointDetails : CreateResolverEndpointDetails
    {
        
        /// <value>
        /// The OCID of a subnet. Must be part of the VCN that the resolver is attached to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// An array of network security group OCIDs for the resolver endpoint. These must be part of the VCN that the
        /// resolver endpoint is a part of.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        [JsonProperty(PropertyName = "endpointType")]
        private readonly string endpointType = "VNIC";
    }
}
