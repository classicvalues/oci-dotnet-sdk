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
    /// LogAnalyticsAssociationParameter
    /// </summary>
    public class LogAnalyticsAssociationParameter 
    {
        
        /// <value>
        /// The agent unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// The entity type.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The entity unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The source name.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The source display name.
        /// </value>
        [JsonProperty(PropertyName = "sourceDisplayName")]
        public string SourceDisplayName { get; set; }
        
        /// <value>
        /// The source type.
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        public string SourceType { get; set; }
                ///
        /// <value>
        /// The status.  Either FAILED or SUCCEEDED.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The status.  Either FAILED or SUCCEEDED.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A list of missing properties.
        /// </value>
        [JsonProperty(PropertyName = "missingProperties")]
        public System.Collections.Generic.List<string> MissingProperties { get; set; }
        
        /// <value>
        /// A list of requried properties.
        /// </value>
        [JsonProperty(PropertyName = "requiredProperties")]
        public System.Collections.Generic.List<string> RequiredProperties { get; set; }
        
    }
}
