/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// Source IP information for reverse connection configuration.
    /// </summary>
    public class DatabaseToolsPrivateEndpointReverseConnectionsSourceIp 
    {
        
        /// <value>
        /// The IP address in the customer's VCN to be used as the source IP for reverse connection packets
        /// traveling from the customer's VCN to the service's VCN.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceIp")]
        public string SourceIp { get; set; }
        
    }
}
