/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// The body for updating an existing resolver VNIC endpoint.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpdateResolverVnicEndpointDetails : UpdateResolverEndpointDetails
    {
        
        /// <value>
        /// An array of NSG OCIDs for the resolver endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        [JsonProperty(PropertyName = "endpointType")]
        private readonly string endpointType = "VNIC";
    }
}
