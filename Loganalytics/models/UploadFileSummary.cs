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
    /// Details of Upload File.
    /// </summary>
    public class UploadFileSummary 
    {
        
        /// <value>
        /// Unique internal identifier to refer upload file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Reference is required.")]
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }
        
        /// <value>
        /// Name of the file
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Processing status of the file.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCESSFUL")]
            Successful,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Processing status of the file.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Number of estimated chunks for this file. A chunk is a portion of the log file used for the processing.
        /// </value>
        [JsonProperty(PropertyName = "totalChunks")]
        public System.Nullable<decimal> TotalChunks { get; set; }
        
        /// <value>
        /// Number of chunks processed.
        /// </value>
        [JsonProperty(PropertyName = "chunksConsumed")]
        public System.Nullable<decimal> ChunksConsumed { get; set; }
        
        /// <value>
        /// Number of chunks processed successfully.
        /// </value>
        [JsonProperty(PropertyName = "chunksSuccess")]
        public System.Nullable<decimal> ChunksSuccess { get; set; }
        
        /// <value>
        /// Number of chunks failed processing.
        /// </value>
        [JsonProperty(PropertyName = "chunksFail")]
        public System.Nullable<decimal> ChunksFail { get; set; }
        
        /// <value>
        /// The time when this file processing started.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// Name of the log source used for processing this file.
        /// </value>
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// Name of the entity type.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// Name of the entity associated with the file.
        /// </value>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// (Deprecated) Name of the log namespace associated with the file.
        /// </value>
        [JsonProperty(PropertyName = "logNamespace")]
        public string LogNamespace { get; set; }
        
        /// <value>
        /// Log group OCID associated with the file.
        /// </value>
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }
        
        /// <value>
        /// Name of the log group associated with the file.
        /// </value>
        [JsonProperty(PropertyName = "logGroupName")]
        public string LogGroupName { get; set; }
        
        /// <value>
        /// The details about upload processing failure.
        /// </value>
        [JsonProperty(PropertyName = "failureDetails")]
        public string FailureDetails { get; set; }
        
    }
}
