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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The connection details for an Autonomous Transaction Processing data asset.
    /// </summary>
    public class ConnectionSummaryFromAtp : ConnectionSummary
    {
        
        /// <value>
        /// The Autonomous Transaction Processing instance service name.
        /// </value>
        [JsonProperty(PropertyName = "tnsAlias")]
        public string TnsAlias { get; set; }
        
        /// <value>
        /// Array of service names that are available for selection in the tnsAlias property.
        /// </value>
        [JsonProperty(PropertyName = "tnsNames")]
        public System.Collections.Generic.List<string> TnsNames { get; set; }
        
        /// <value>
        /// The user name for the connection.
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password for the connection.
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        [JsonProperty(PropertyName = "passwordSecret")]
        public SensitiveAttribute PasswordSecret { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLE_ATP_CONNECTION";
    }
}
