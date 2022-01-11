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
    /// Description of log analytics entity type.
    /// 
    /// </summary>
    public class LogAnalyticsEntityType 
    {
        
        /// <value>
        /// Log analytics entity type name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Internal name for the log analytics entity type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InternalName is required.")]
        [JsonProperty(PropertyName = "internalName")]
        public string InternalName { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Log analytics entity type category. Category will be used for grouping and filtering.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// Log analytics entity type group. That can be CLOUD (OCI) or NON_CLOUD otherwise.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudType is required.")]
        [JsonProperty(PropertyName = "cloudType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EntityCloudType> CloudType { get; set; }
        
        /// <value>
        /// The parameters used in file patterns specified in log sources for this log analytics entity type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<EntityTypeProperty> Properties { get; set; }
        
        /// <value>
        /// The current lifecycle state of the log analytics entity.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EntityLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Time the log analytics entity type was created. An RFC3339 formatted datetime string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time the log analytics entity type was updated. An RFC3339 formatted datetime string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// This field indicates whether logs for entities of this type can be collected using a management agent.
        /// 
        /// </value>
        ///
        public enum ManagementAgentEligibilityStatusEnum {
            [EnumMember(Value = "ELIGIBLE")]
            Eligible,
            [EnumMember(Value = "INELIGIBLE")]
            Ineligible,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// This field indicates whether logs for entities of this type can be collected using a management agent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "managementAgentEligibilityStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ManagementAgentEligibilityStatusEnum> ManagementAgentEligibilityStatus { get; set; }
        
    }
}
