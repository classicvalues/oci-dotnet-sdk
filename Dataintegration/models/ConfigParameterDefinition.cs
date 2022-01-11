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
    /// The configurable properties of an object type.
    /// </summary>
    public class ConfigParameterDefinition 
    {
        
        [JsonProperty(PropertyName = "parameterType")]
        public BaseType ParameterType { get; set; }
        
        /// <value>
        /// This object represents the configurable properties for an object type.
        /// </value>
        [JsonProperty(PropertyName = "parameterName")]
        public string ParameterName { get; set; }
        
        /// <value>
        /// A user defined description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The default value for the parameter.
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public System.Object DefaultValue { get; set; }
        
        /// <value>
        /// The parameter class field name.
        /// </value>
        [JsonProperty(PropertyName = "classFieldName")]
        public string ClassFieldName { get; set; }
        
        /// <value>
        /// Specifies whether the parameter is static or not.
        /// </value>
        [JsonProperty(PropertyName = "isStatic")]
        public System.Nullable<bool> IsStatic { get; set; }
        
        /// <value>
        /// Specifies whether the parameter is a class field or not.
        /// </value>
        [JsonProperty(PropertyName = "isClassFieldValue")]
        public System.Nullable<bool> IsClassFieldValue { get; set; }
        
    }
}
