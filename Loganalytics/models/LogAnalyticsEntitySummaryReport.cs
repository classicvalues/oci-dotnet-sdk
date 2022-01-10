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
    /// Log-Analytics entity counts summary.
    /// 
    /// </summary>
    public class LogAnalyticsEntitySummaryReport 
    {
        
        /// <value>
        /// Total number of ACTIVE entities
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActiveEntitiesCount is required.")]
        [JsonProperty(PropertyName = "activeEntitiesCount")]
        public System.Nullable<int> ActiveEntitiesCount { get; set; }
        
        /// <value>
        /// Entities with log collection enabled
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntitiesWithHasLogsCollectedCount is required.")]
        [JsonProperty(PropertyName = "entitiesWithHasLogsCollectedCount")]
        public System.Nullable<int> EntitiesWithHasLogsCollectedCount { get; set; }
        
        /// <value>
        /// Entities with management agent
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntitiesWithManagementAgentCount is required.")]
        [JsonProperty(PropertyName = "entitiesWithManagementAgentCount")]
        public System.Nullable<int> EntitiesWithManagementAgentCount { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
    }
}
