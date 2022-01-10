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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// SDK target language details.
    /// 
    /// </summary>
    public class SdkLanguageTypes 
    {
        
        /// <value>
        /// Name of the programming language.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Display name of the target programming language.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Version string of the programming language defined in name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Additional details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// List of optional configurations that can be used while generating SDK for the given target language.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<SdkLanguageOptionalParameters> Parameters { get; set; }
        
    }
}
