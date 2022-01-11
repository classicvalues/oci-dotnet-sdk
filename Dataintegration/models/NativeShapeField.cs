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
    /// The native shape field object.
    /// </summary>
    public class NativeShapeField 
    {
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The model type reference.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        /// <value>
        /// The type reference.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public System.Object Type { get; set; }
        
        [JsonProperty(PropertyName = "configValues")]
        public ConfigValues ConfigValues { get; set; }
        
        /// <value>
        /// The position of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "position")]
        public System.Nullable<int> Position { get; set; }
        
        /// <value>
        /// The default value.
        /// </value>
        [JsonProperty(PropertyName = "defaultValueString")]
        public string DefaultValueString { get; set; }
        
        /// <value>
        /// Specifies whether the field is mandatory.
        /// </value>
        [JsonProperty(PropertyName = "isMandatory")]
        public System.Nullable<bool> IsMandatory { get; set; }
        
    }
}
