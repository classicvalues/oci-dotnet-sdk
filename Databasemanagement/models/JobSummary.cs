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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A summary of the job.
    /// </summary>
    public class JobSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which the job resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The description of the job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database Group where the job has to be executed.
        /// </value>
        [JsonProperty(PropertyName = "managedDatabaseGroupId")]
        public string ManagedDatabaseGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database where the job has to be executed.
        /// </value>
        [JsonProperty(PropertyName = "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The subtype of the Oracle Database where the job has to be executed. Only applicable when managedDatabaseGroupId is provided.
        /// </value>
        [JsonProperty(PropertyName = "databaseSubType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseSubType> DatabaseSubType { get; set; }
        
        /// <value>
        /// The schedule type of the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleType is required.")]
        [JsonProperty(PropertyName = "scheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Job.ScheduleTypeEnum> ScheduleType { get; set; }
        
        [JsonProperty(PropertyName = "scheduleDetails")]
        public JobScheduleDetails ScheduleDetails { get; set; }
        
        /// <value>
        /// The type of job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobType is required.")]
        [JsonProperty(PropertyName = "jobType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobTypes> JobType { get; set; }
        
        /// <value>
        /// The lifecycle state of the job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Job.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The job timeout duration, which is expressed like \"1h 10m 15s\".
        /// </value>
        [JsonProperty(PropertyName = "timeout")]
        public string Timeout { get; set; }
        
        /// <value>
        /// The error message that is returned if the job submission fails. Null is returned in all other scenarios.
        /// </value>
        [JsonProperty(PropertyName = "submissionErrorMessage")]
        public string SubmissionErrorMessage { get; set; }
        
        /// <value>
        /// The date and time when the job was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the job was last updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
