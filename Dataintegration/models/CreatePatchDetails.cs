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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Properties used in patch create operations.
    /// </summary>
    public class CreatePatchDetails 
    {
        
        /// <value>
        /// The object's key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// The object's model version.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }

        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }

        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        ///
        /// <value>
        /// The type of the patch applied or being applied on the application.
        /// </value>
        ///
        public enum PatchTypeEnum {
            [EnumMember(Value = "PUBLISH")]
            Publish,
            [EnumMember(Value = "REFRESH")]
            Refresh,
            [EnumMember(Value = "UNPUBLISH")]
            Unpublish
        };

        /// <value>
        /// The type of the patch applied or being applied on the application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchType is required.")]
        [JsonProperty(PropertyName = "patchType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PatchTypeEnum> PatchType { get; set; }

        /// <value>
        /// The array of object keys to publish into application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectKeys is required.")]
        [JsonProperty(PropertyName = "objectKeys")]
        public System.Collections.Generic.List<string> ObjectKeys { get; set; }

        [JsonProperty(PropertyName = "registryMetadata")]
        public RegistryMetadata RegistryMetadata { get; set; }
    }
}
