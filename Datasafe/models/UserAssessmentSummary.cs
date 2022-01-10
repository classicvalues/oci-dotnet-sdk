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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The summary of the user assessment.
    /// </summary>
    public class UserAssessmentSummary 
    {
        
        /// <value>
        /// The OCID of the compartment that contains the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The description of the user assessment.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The display name of the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// List containing maps as values.
        /// Example: {&quot;Operations&quot;: [ {&quot;CostCenter&quot;: &quot;42&quot;} ] }
        /// </value>
        [JsonProperty(PropertyName = "ignoredTargets")]
        public System.Collections.Generic.List<System.Object> IgnoredTargets { get; set; }
        
        /// <value>
        /// List containing maps as values.
        /// Example: {&quot;Operations&quot;: [ {&quot;CostCenter&quot;: &quot;42&quot;} ] }
        /// </value>
        [JsonProperty(PropertyName = "ignoredAssessmentIds")]
        public System.Collections.Generic.List<System.Object> IgnoredAssessmentIds { get; set; }
        
        /// <value>
        /// Indicates if the assessment is a baseline assessment. This applies to saved user assessments only.
        /// </value>
        [JsonProperty(PropertyName = "isBaseline")]
        public System.Nullable<bool> IsBaseline { get; set; }
        
        /// <value>
        /// Indicates if the assessment has deviated from the baseline.
        /// </value>
        [JsonProperty(PropertyName = "isDeviatedFromBaseline")]
        public System.Nullable<bool> IsDeviatedFromBaseline { get; set; }
        
        /// <value>
        /// The OCID of the last user assessment baseline against which the latest assessment was compared.
        /// </value>
        [JsonProperty(PropertyName = "lastComparedBaselineId")]
        public string LastComparedBaselineId { get; set; }
        
        /// <value>
        /// The current state of the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UserAssessmentLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current state of the user assessment.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the user assessment that created this scheduled save assessment.
        /// </value>
        [JsonProperty(PropertyName = "scheduleAssessmentId")]
        public string ScheduleAssessmentId { get; set; }
        
        /// <value>
        /// Schedule to save the assessment periodically in the specified format:
        /// <version-string>;<version-specific-schedule>
        /// <br/>
        /// Allowed version strings - \"v1\"
        /// v1's version specific schedule -<ss> <mm> <hh> <day-of-week> <day-of-month>
        /// Each of the above fields potentially introduce constraints. A workrequest is created only
        /// when clock time satisfies all the constraints. Constraints introduced:
        /// 1. seconds = <ss> (So, the allowed range for <ss> is [0, 59])
        /// 2. minutes = <mm> (So, the allowed range for <mm> is [0, 59])
        /// 3. hours = <hh> (So, the allowed range for <hh> is [0, 23])
        /// <day-of-week> can be either '*' (without quotes or a number between 1(Monday) and 7(Sunday))
        /// 4. No constraint introduced when it is '*'. When not, day of week must equal the given value
        /// <day-of-month> can be either '*' (without quotes or a number between 1 and 28)
        /// 5. No constraint introduced when it is '*'. When not, day of month must equal the given value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }
        
        /// <value>
        /// Map that contains maps of values.
        ///  Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "statistics")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> Statistics { get; set; }
        
        /// <value>
        /// Array of database target OCIDs.
        /// </value>
        [JsonProperty(PropertyName = "targetIds")]
        public System.Collections.Generic.List<string> TargetIds { get; set; }
        
        /// <value>
        /// The date and time when the user assessment was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last date and time when the user assessment was updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// Indicates whether the user assessment was created by system or user.
        /// </value>
        ///
        public enum TriggeredByEnum {
            [EnumMember(Value = "USER")]
            User,
            [EnumMember(Value = "SYSTEM")]
            System
        };

        /// <value>
        /// Indicates whether the user assessment was created by system or user.
        /// </value>
        [JsonProperty(PropertyName = "triggeredBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TriggeredByEnum> TriggeredBy { get; set; }
                ///
        /// <value>
        /// Type of user assessment. The possible types are:
        /// <br/>
        /// LATEST: The most up-to-date assessment that is running automatically for a target. It is system generated.
        /// SAVED: A saved user assessment. LATEST assessments are always saved to maintain the history of runs. A SAVED assessment is also generated by a 'refresh' action (triggered by the user).
        /// SAVE_SCHEDULE: The schedule for periodic save of LATEST assessments.
        /// COMPARTMENT: An automatic managed assessment type that stores all details of targets in one compartment. This type keeps an up-to-date status of all database risks in one compartment.
        ///        It is automatically updated when the latest assessment or refresh action is executed. It is also automatically updated when a target is deleted or move to a different compartment.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "LATEST")]
            Latest,
            [EnumMember(Value = "SAVED")]
            Saved,
            [EnumMember(Value = "SAVE_SCHEDULE")]
            SaveSchedule,
            [EnumMember(Value = "COMPARTMENT")]
            Compartment
        };

        /// <value>
        /// Type of user assessment. The possible types are:
        /// <br/>
        /// LATEST: The most up-to-date assessment that is running automatically for a target. It is system generated.
        /// SAVED: A saved user assessment. LATEST assessments are always saved to maintain the history of runs. A SAVED assessment is also generated by a 'refresh' action (triggered by the user).
        /// SAVE_SCHEDULE: The schedule for periodic save of LATEST assessments.
        /// COMPARTMENT: An automatic managed assessment type that stores all details of targets in one compartment. This type keeps an up-to-date status of all database risks in one compartment.
        ///        It is automatically updated when the latest assessment or refresh action is executed. It is also automatically updated when a target is deleted or move to a different compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
