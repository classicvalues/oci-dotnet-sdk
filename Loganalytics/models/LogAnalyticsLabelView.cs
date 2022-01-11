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
    /// LogAnalyticsLabelView
    /// </summary>
    public class LogAnalyticsLabelView 
    {
        
        /// <value>
        /// An arrya of label aliases.
        /// </value>
        [JsonProperty(PropertyName = "aliases")]
        public System.Collections.Generic.List<LogAnalyticsLabelAlias> Aliases { get; set; }
        
        /// <value>
        /// The label alert rule usage count.
        /// </value>
        [JsonProperty(PropertyName = "countUsageInAlertRule")]
        public System.Nullable<long> CountUsageInAlertRule { get; set; }
        
        /// <value>
        /// The label source usage count.
        /// </value>
        [JsonProperty(PropertyName = "countUsageInSource")]
        public System.Nullable<long> CountUsageInSource { get; set; }
        
        /// <value>
        /// The label unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public System.Object Id { get; set; }
        
        /// <value>
        /// The label suggestion type.
        /// </value>
        [JsonProperty(PropertyName = "suggestType")]
        public System.Nullable<long> SuggestType { get; set; }
        
        /// <value>
        /// The label description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The label display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The label edit version.
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// The label impact.
        /// </value>
        [JsonProperty(PropertyName = "impact")]
        public string Impact { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The label name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The label priority.  Default value is NONE.
        /// </value>
        ///
        public enum PriorityEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "HIGH")]
            High
        };

        /// <value>
        /// The label priority.  Default value is NONE.
        /// </value>
        [JsonProperty(PropertyName = "priority")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PriorityEnum> Priority { get; set; }
        
        /// <value>
        /// The label recommendation.
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// The label type.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public System.Nullable<long> Type { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the label has been deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isUserDeleted")]
        public System.Nullable<bool> IsUserDeleted { get; set; }
        
    }
}
