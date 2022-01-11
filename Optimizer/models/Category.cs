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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// The metadata associated with the category.
    /// 
    /// </summary>
    public class Category 
    {
        
        /// <value>
        /// The unique OCID of the category.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the tenancy. The tenancy is the root compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name assigned to the category.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Text describing the category.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// An array of `RecommendationCount` objects grouped by the level of importance assigned to the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecommendationCounts is required.")]
        [JsonProperty(PropertyName = "recommendationCounts")]
        public System.Collections.Generic.List<RecommendationCount> RecommendationCounts { get; set; }
        
        /// <value>
        /// An array of `ResourceCount` objects grouped by the status of the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCounts is required.")]
        [JsonProperty(PropertyName = "resourceCounts")]
        public System.Collections.Generic.List<ResourceCount> ResourceCounts { get; set; }
        
        /// <value>
        /// The category's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The estimated cost savings, in dollars, for the category.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EstimatedCostSaving is required.")]
        [JsonProperty(PropertyName = "estimatedCostSaving")]
        public System.Double EstimatedCostSaving { get; set; }
        
        /// <value>
        /// The date and time the category details were created, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the category details were last updated, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Additional metadata key/value pairs for the category.
        /// <br/>
        /// For Example: {&quot;EstimatedSaving&quot;: &quot;200&quot;}
        /// </value>
        [JsonProperty(PropertyName = "extendedMetadata")]
        public System.Collections.Generic.Dictionary<string, string> ExtendedMetadata { get; set; }
        
    }
}
