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
    /// Details of a single custom property
    /// </summary>
    public class CustomPropertyGetUsage 
    {
        
        /// <value>
        /// Unique Identifier of the attribute which is ID
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Display name of the custom property
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the custom property
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The custom property value
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// The data type of the custom property
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CustomPropertyDataType> DataType { get; set; }
        
        /// <value>
        /// Namespace name of the custom property
        /// </value>
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Unique namespace key that is immutable
        /// </value>
        [JsonProperty(PropertyName = "namespaceKey")]
        public string NamespaceKey { get; set; }
        
        /// <value>
        /// If this field allows multiple values to be set
        /// </value>
        [JsonProperty(PropertyName = "isMultiValued")]
        public System.Nullable<bool> IsMultiValued { get; set; }
        
        /// <value>
        /// If this field is a hidden field
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// If this field is a editable field
        /// </value>
        [JsonProperty(PropertyName = "isEditable")]
        public System.Nullable<bool> IsEditable { get; set; }
        
        /// <value>
        /// If this field is displayed in a list view of applicable objects.
        /// </value>
        [JsonProperty(PropertyName = "isShownInList")]
        public System.Nullable<bool> IsShownInList { get; set; }
        
        /// <value>
        /// If an OCI Event will be emitted when the custom property is modified.
        /// </value>
        [JsonProperty(PropertyName = "isEventEnabled")]
        public System.Nullable<bool> IsEventEnabled { get; set; }
        
        /// <value>
        /// Is this property allowed to have list of values
        /// </value>
        [JsonProperty(PropertyName = "isListType")]
        public System.Nullable<bool> IsListType { get; set; }
        
        /// <value>
        /// Allowed values for the custom property if any
        /// </value>
        [JsonProperty(PropertyName = "allowedValues")]
        public System.Collections.Generic.List<string> AllowedValues { get; set; }
        
    }
}
