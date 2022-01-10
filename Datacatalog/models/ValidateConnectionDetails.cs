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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Validate connection from the connection metadata or oracle wallet file.
    /// </summary>
    public class ValidateConnectionDetails 
    {
        
        [JsonProperty(PropertyName = "connectionDetail")]
        public CreateConnectionDetails ConnectionDetail { get; set; }
        
        /// <value>
        /// The information used to validate the connection.
        /// </value>
        [JsonProperty(PropertyName = "connectionPayload")]
        public System.Byte[] ConnectionPayload { get; set; }
        
    }
}
