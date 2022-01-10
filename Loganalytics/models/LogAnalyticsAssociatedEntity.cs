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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsAssociatedEntity
    /// </summary>
    public class LogAnalyticsAssociatedEntity 
    {
        
        /// <value>
        /// The entity unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The entity name.
        /// </value>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// The entity type.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The entity type display name.
        /// </value>
        [JsonProperty(PropertyName = "entityTypeDisplayName")]
        public string EntityTypeDisplayName { get; set; }
        
        /// <value>
        /// The host associated with the entity.
        /// </value>
        [JsonProperty(PropertyName = "onHost")]
        public string OnHost { get; set; }
        
        /// <value>
        /// The association count for the entity.
        /// </value>
        [JsonProperty(PropertyName = "associationCount")]
        public System.Nullable<long> AssociationCount { get; set; }
        
    }
}
