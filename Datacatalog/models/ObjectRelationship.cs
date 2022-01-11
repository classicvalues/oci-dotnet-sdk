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
    /// Details regarding a specific object and its relationship to the referencing object.
    /// </summary>
    public class ObjectRelationship 
    {
        
        /// <value>
        /// Type of relationship with the referencing object.
        /// </value>
        [JsonProperty(PropertyName = "relationshipType")]
        public string RelationshipType { get; set; }
        
        /// <value>
        /// Unique id of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Name of the object.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Type name of the object. Type names can be found via the '/types' endpoint.
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }
        
        /// <value>
        /// Type key of the object. Type keys can be found via the '/types' endpoint.
        /// </value>
        [JsonProperty(PropertyName = "typeKey")]
        public string TypeKey { get; set; }
        
        /// <value>
        /// The date and time the relationship was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time a change was made to this reference. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Full path of the object.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// Key of the parent object for the resource.
        /// </value>
        [JsonProperty(PropertyName = "parentKey")]
        public string ParentKey { get; set; }
        
        /// <value>
        /// Full path of the parent object.
        /// </value>
        [JsonProperty(PropertyName = "parentPath")]
        public string ParentPath { get; set; }
        
    }
}
