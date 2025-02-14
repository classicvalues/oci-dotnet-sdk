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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Details about the Oracle Analytics Cloud - Classic application in the source environment.
    /// 
    /// </summary>
    public class OacDiscoveryDetails : DiscoveryDetails
    {
        
        /// <value>
        /// This field is currently not supported. You must enter a value, such as <code>unused</code>. However, the value that you enter is ignored.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceInstanceUser is required.")]
        [JsonProperty(PropertyName = "serviceInstanceUser")]
        public string ServiceInstanceUser { get; set; }
        
        /// <value>
        /// This field is currently not supported. You must enter a value, such as <code>unused</code>. However, the value that you enter is ignored.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceInstancePassword is required.")]
        [JsonProperty(PropertyName = "serviceInstancePassword")]
        public string ServiceInstancePassword { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "OAC";
    }
}
