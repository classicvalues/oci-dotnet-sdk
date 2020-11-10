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
    /// Details specific to performing a DynECT zone migration.
    /// 
    /// </summary>
    public class DynectMigrationDetails 
    {
        
        /// <value>
        /// DynECT customer name the zone belongs to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CustomerName is required.")]
        [JsonProperty(PropertyName = "customerName")]
        public string CustomerName { get; set; }
        
        /// <value>
        /// DynECT API username to perform the migration with.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// DynECT API password for the provided username.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Password is required.")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// A map of fully-qualified domain names (FQDNs) to an array of `MigrationReplacement` objects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "httpRedirectReplacements")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<MigrationReplacement>> HttpRedirectReplacements { get; set; }
        
    }
}
