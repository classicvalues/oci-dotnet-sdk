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
    /// This shows the storage work request details.
    /// 
    /// </summary>
    public class StorageWorkRequest 
    {
        
        /// <value>
        /// This is the OCID of the storage work Request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// When the work request started.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// When the work request was accepted. Should match timeStarted in all cases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// When the work request finished execution.
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// When the work request will expire.
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
        
        /// <value>
        /// Percentage progress completion of the work request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<int> PercentComplete { get; set; }
        
        /// <value>
        /// This is the work request status.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<WorkRequestStatus> Status { get; set; }
        
        /// <value>
        /// This is the start of the time interval
        /// </value>
        [JsonProperty(PropertyName = "timeDataStarted")]
        public System.Nullable<System.DateTime> TimeDataStarted { get; set; }
        
        /// <value>
        /// This is the end of the time interval
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataEnded is required.")]
        [JsonProperty(PropertyName = "timeDataEnded")]
        public System.Nullable<System.DateTime> TimeDataEnded { get; set; }
        
        /// <value>
        /// This is the solr query used to filter data for purge, '*' means all
        /// </value>
        [JsonProperty(PropertyName = "purgeQueryString")]
        public string PurgeQueryString { get; set; }
        
        /// <value>
        /// Thie is the type of data to be purged
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataType is required.")]
        [JsonProperty(PropertyName = "dataType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageDataType> DataType { get; set; }
        
        /// <value>
        /// This provides more detailed status if applicable
        /// </value>
        [JsonProperty(PropertyName = "statusDetails")]
        public string StatusDetails { get; set; }
        
        /// <value>
        /// This provides more detailed info about the work request if applicable
        /// </value>
        [JsonProperty(PropertyName = "operationDetails")]
        public string OperationDetails { get; set; }
        
        /// <value>
        /// This is the policy name if applicable (e.g. purge policy)
        /// </value>
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; set; }
        
        /// <value>
        /// This is the purge policy ID if applicable
        /// </value>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }
        
        /// <value>
        /// This is the data usage in bytes if applicable
        /// </value>
        [JsonProperty(PropertyName = "storageUsageInBytes")]
        public System.Nullable<long> StorageUsageInBytes { get; set; }
        
        /// <value>
        /// If true, purge child compartments data, only applicable to purge request
        /// </value>
        [JsonProperty(PropertyName = "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// This is the type of the work request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageOperationType> OperationType { get; set; }
        
    }
}
