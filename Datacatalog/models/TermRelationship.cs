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
    /// Full term relationship definition. Business term relationship between two terms in a business glossary.
    /// 
    /// </summary>
    public class TermRelationship 
    {
        
        /// <value>
        /// Unique term relationship key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.This is the same as relationshipType for termRelationship
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the term relationship usually defined at the time of creation.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Unique id of the related term.
        /// </value>
        [JsonProperty(PropertyName = "relatedTermKey")]
        public string RelatedTermKey { get; set; }
        
        /// <value>
        /// Name of the related term.
        /// </value>
        [JsonProperty(PropertyName = "relatedTermDisplayName")]
        public string RelatedTermDisplayName { get; set; }
        
        /// <value>
        /// Description of the related term.
        /// </value>
        [JsonProperty(PropertyName = "relatedTermDescription")]
        public string RelatedTermDescription { get; set; }
        
        /// <value>
        /// Full path of the related term.
        /// </value>
        [JsonProperty(PropertyName = "relatedTermPath")]
        public string RelatedTermPath { get; set; }
        
        /// <value>
        /// Glossary key of the related term.
        /// </value>
        [JsonProperty(PropertyName = "relatedTermGlossaryKey")]
        public string RelatedTermGlossaryKey { get; set; }
        
        /// <value>
        /// URI to the term relationship instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// This relationships parent term key.
        /// </value>
        [JsonProperty(PropertyName = "parentTermKey")]
        public string ParentTermKey { get; set; }
        
        /// <value>
        /// Name of the parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermDisplayName")]
        public string ParentTermDisplayName { get; set; }
        
        /// <value>
        /// Description of the parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermDescription")]
        public string ParentTermDescription { get; set; }
        
        /// <value>
        /// Full path of the parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermPath")]
        public string ParentTermPath { get; set; }
        
        /// <value>
        /// Glossary key of the parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermGlossaryKey")]
        public string ParentTermGlossaryKey { get; set; }
        
        /// <value>
        /// The date and time the term relationship was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// State of the term relationship.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
    }
}
