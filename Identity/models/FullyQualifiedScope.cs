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


namespace Oci.IdentityService.Models
{
    
    public class FullyQualifiedScope 
    {
        
        /// <value>
        /// Audience for the given scope context.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Audience is required.")]
        [JsonProperty(PropertyName = "audience")]
        public string Audience { get; set; }
        
        /// <value>
        /// Allowed permission scope for the given context.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scope is required.")]
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
        
    }
}
