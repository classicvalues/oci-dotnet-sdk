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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Configuration details for the SCRIPTED_BROWSER monitor type.
    /// </summary>
    public class ScriptedBrowserMonitorConfiguration : MonitorConfiguration
    {
        
        /// <value>
        /// If certificate validation is enabled, then the call will fail in case of certification errors.
        /// </value>
        [JsonProperty(PropertyName = "isCertificateValidationEnabled")]
        public System.Nullable<bool> IsCertificateValidationEnabled { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "SCRIPTED_BROWSER_CONFIG";
    }
}
