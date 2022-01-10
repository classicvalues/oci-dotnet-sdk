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
    /// Details of a single type property.
    /// </summary>
    public class PropertyDefinition 
    {
        
        /// <value>
        /// Name of the property.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The properties value type.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Whether instances of the type are required to set this property.
        /// </value>
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }
        
        /// <value>
        /// Indicates if this property value can be updated.
        /// </value>
        [JsonProperty(PropertyName = "isUpdatable")]
        public System.Nullable<bool> IsUpdatable { get; set; }
        
    }
}
