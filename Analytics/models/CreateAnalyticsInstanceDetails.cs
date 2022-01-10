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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Input payload to create an Anaytics instance.
    /// 
    /// </summary>
    public class CreateAnalyticsInstanceDetails 
    {
        
        /// <value>
        /// The name of the Analytics instance. This name must be unique in the tenancy and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Optional description.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Analytics feature set.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FeatureSet is required.")]
        [JsonProperty(PropertyName = "featureSet")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<FeatureSet> FeatureSet { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Capacity is required.")]
        [JsonProperty(PropertyName = "capacity")]
        public Capacity Capacity { get; set; }
        
        /// <value>
        /// The license used for the service.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseType is required.")]
        [JsonProperty(PropertyName = "licenseType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseType> LicenseType { get; set; }
        
        /// <value>
        /// Email address receiving notifications.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "emailNotification")]
        public string EmailNotification { get; set; }
        
        [JsonProperty(PropertyName = "networkEndpointDetails")]
        public NetworkEndpointDetails NetworkEndpointDetails { get; set; }
        
        /// <value>
        /// IDCS access token identifying a stripe and service administrator user.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "idcsAccessToken")]
        public string IdcsAccessToken { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
    }
}
