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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The record of a maintenance update action performed on a specified VM cluster. Applies to Exadata Cloud@Customer instances only.
    /// 
    /// </summary>
    public class VmClusterUpdateHistoryEntrySummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the maintenance update history entry.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the maintenance update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateId is required.")]
        [JsonProperty(PropertyName = "updateId")]
        public string UpdateId { get; set; }
                ///
        /// <value>
        /// The update action performed using this maintenance update.
        /// </value>
        ///
        public enum UpdateActionEnum {
            [EnumMember(Value = "ROLLING_APPLY")]
            RollingApply,
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "ROLLBACK")]
            Rollback
        };

        /// <value>
        /// The update action performed using this maintenance update.
        /// </value>
        [JsonProperty(PropertyName = "updateAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateActionEnum> UpdateAction { get; set; }
                ///
        /// <value>
        /// The type of VM cluster maintenance update.
        /// </value>
        ///
        public enum UpdateTypeEnum {
            [EnumMember(Value = "GI_UPGRADE")]
            GiUpgrade,
            [EnumMember(Value = "GI_PATCH")]
            GiPatch,
            [EnumMember(Value = "OS_UPDATE")]
            OsUpdate
        };

        /// <value>
        /// The type of VM cluster maintenance update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateType is required.")]
        [JsonProperty(PropertyName = "updateType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateTypeEnum> UpdateType { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the maintenance update operation.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current lifecycle state of the maintenance update operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Descriptive text providing additional details about the lifecycle state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time when the maintenance update action started.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time when the maintenance update action completed.
        /// </value>
        [JsonProperty(PropertyName = "timeCompleted")]
        public System.Nullable<System.DateTime> TimeCompleted { get; set; }
        
    }
}
