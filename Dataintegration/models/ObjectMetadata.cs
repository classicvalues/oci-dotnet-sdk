/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// A summary type containing information about the object including its key, name and when/who created/updated it.
    /// </summary>
    public class ObjectMetadata 
    {
        
        /// <value>
        /// The user that created the object.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// The user that created the object.
        /// </value>
        [JsonProperty(PropertyName = "createdByName")]
        public string CreatedByName { get; set; }
        
        /// <value>
        /// The user that updated the object.
        /// </value>
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        
        /// <value>
        /// The user that updated the object.
        /// </value>
        [JsonProperty(PropertyName = "updatedByName")]
        public string UpdatedByName { get; set; }
        
        /// <value>
        /// The date and time that the object was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time that the object was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The owning object key for this object.
        /// </value>
        [JsonProperty(PropertyName = "aggregatorKey")]
        public string AggregatorKey { get; set; }
        
        [JsonProperty(PropertyName = "aggregator")]
        public AggregatorSummary Aggregator { get; set; }
        
        /// <value>
        /// The full path to identify this object.
        /// </value>
        [JsonProperty(PropertyName = "identifierPath")]
        public string IdentifierPath { get; set; }
        
        /// <value>
        /// Information property fields.
        /// </value>
        [JsonProperty(PropertyName = "infoFields")]
        public System.Collections.Generic.Dictionary<string, string> InfoFields { get; set; }
        
        /// <value>
        /// The registry version of the object.
        /// </value>
        [JsonProperty(PropertyName = "registryVersion")]
        public System.Nullable<int> RegistryVersion { get; set; }
        
        /// <value>
        /// Labels are keywords or tags that you can add to data assets, dataflows and so on. You can define your own labels and use them to categorize content.
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        /// <value>
        /// Specifies whether this object is a favorite or not.
        /// </value>
        [JsonProperty(PropertyName = "isFavorite")]
        public System.Nullable<bool> IsFavorite { get; set; }
        
    }
}
