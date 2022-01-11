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


namespace Oci.WaasService.Models
{
    
    public class Certificate_extensions 
    {
        
        /// <value>
        /// The certificate extension name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The critical flag of the extension. Critical extensions must be processed, non-critical extensions can be ignored.
        /// </value>
        [JsonProperty(PropertyName = "isCritical")]
        public System.Nullable<bool> IsCritical { get; set; }
        
        /// <value>
        /// The certificate extension value.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
    }
}
