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
    /// A summary of the changes made to a single AWR database parameter.
    /// </summary>
    public class AwrDbParameterChangeSummary 
    {
        
        /// <value>
        /// The start time of the interval.
        /// </value>
        [JsonProperty(PropertyName = "timeBegin")]
        public System.Nullable<System.DateTime> TimeBegin { get; set; }
        
        /// <value>
        /// The end time of the interval.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The database instance number.
        /// </value>
        [JsonProperty(PropertyName = "instanceNumber")]
        public System.Nullable<int> InstanceNumber { get; set; }
        
        /// <value>
        /// The previous value of the database parameter.
        /// </value>
        [JsonProperty(PropertyName = "previousValue")]
        public string PreviousValue { get; set; }
        
        /// <value>
        /// The current value of the database parameter.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// The ID of the snapshot with the parameter value changed. The snapshot ID is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbs/{awrDbId}/awrDbSnapshots
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SnapshotId is required.")]
        [JsonProperty(PropertyName = "snapshotId")]
        public System.Nullable<int> SnapshotId { get; set; }
        
        /// <value>
        /// Indicates whether the parameter has been modified after instance startup:
        ///  - MODIFIED - Parameter has been modified with ALTER SESSION
        ///  - SYSTEM_MOD - Parameter has been modified with ALTER SYSTEM (which causes all the currently logged in sessions\u2019 values to be modified)
        ///  - FALSE - Parameter has not been modified after instance startup
        /// 
        /// </value>
        [JsonProperty(PropertyName = "valueModified")]
        public string ValueModified { get; set; }
        
        /// <value>
        /// Indicates whether the parameter value in the end snapshot is the default.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}
