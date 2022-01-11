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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Representation of a job definition resource. Job definitions define the harvest scope and includes the list
    /// of objects to be harvested along with a schedule. The list of objects is usually specified through a combination
    /// of object type, regular expressions, or specific names of objects and a sample size for the data harvested.
    /// 
    /// </summary>
    public class JobDefinition 
    {
        
        /// <value>
        /// Unique key of the job definition resource that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The data catalog's OCID.
        /// </value>
        [JsonProperty(PropertyName = "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Type of the job definition.
        /// </value>
        [JsonProperty(PropertyName = "jobType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobType> JobType { get; set; }
        
        /// <value>
        /// Specifies if the job definition is incremental or full.
        /// </value>
        [JsonProperty(PropertyName = "isIncremental")]
        public System.Nullable<bool> IsIncremental { get; set; }
        
        /// <value>
        /// The key of the data asset for which the job is defined.
        /// </value>
        [JsonProperty(PropertyName = "dataAssetKey")]
        public string DataAssetKey { get; set; }
        
        /// <value>
        /// Detailed description of the job definition.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The key of the default connection resource to be used for harvest, sampling, profiling jobs.
        /// This may be overridden in each job instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionKey")]
        public string ConnectionKey { get; set; }
        
        /// <value>
        /// Version of the job definition object. Used internally but can be visible to users.
        /// </value>
        [JsonProperty(PropertyName = "internalVersion")]
        public string InternalVersion { get; set; }
        
        /// <value>
        /// Lifecycle state of the job definition.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the job definition was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time that any change was made to the data asset. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created this job definition.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who updated this job definition.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }
        
        /// <value>
        /// URI to the job definition instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// Specify if sample data to be extracted as part of this harvest.
        /// </value>
        [JsonProperty(PropertyName = "isSampleDataExtracted")]
        public System.Nullable<bool> IsSampleDataExtracted { get; set; }
        
        /// <value>
        /// Specify the sample data size in MB, specified as number of rows, for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "sampleDataSizeInMBs")]
        public System.Nullable<int> SampleDataSizeInMBs { get; set; }
        
        /// <value>
        /// Time that the latest job execution started. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeLatestExecutionStarted")]
        public System.Nullable<System.DateTime> TimeLatestExecutionStarted { get; set; }
        
        /// <value>
        /// Time that the latest job execution ended or null if it hasn't yet completed.
        /// An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLatestExecutionEnded")]
        public System.Nullable<System.DateTime> TimeLatestExecutionEnded { get; set; }
        
        /// <value>
        /// Status of the latest job execution, such as running, paused, or completed.
        /// </value>
        [JsonProperty(PropertyName = "jobExecutionState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobExecutionState> JobExecutionState { get; set; }
        
        /// <value>
        /// Type of job schedule for the latest job executed.
        /// </value>
        [JsonProperty(PropertyName = "scheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobScheduleType> ScheduleType { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the job type. Each job type
        /// definition may define it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// job definitions have required properties within the \"default\" category.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;host&quot;: &quot;host1&quot;, &quot;port&quot;: &quot;1521&quot;, &quot;database&quot;: &quot;orcl&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
