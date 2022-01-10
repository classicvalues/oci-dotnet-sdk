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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of an AwrSource.
    /// </summary>
    public class AwrSourceSummary 
    {
        
        /// <value>
        /// AWR Hub OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrHubId is required.")]
        [JsonProperty(PropertyName = "awrHubId")]
        public string AwrHubId { get; set; }
        
        /// <value>
        /// Database name of the Source database for which AWR Data will be uploaded to AWR Hub.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// DatabaseId of the Source database for which AWR Data will be uploaded to AWR Hub.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrSourceDatabaseId is required.")]
        [JsonProperty(PropertyName = "awrSourceDatabaseId")]
        public string AwrSourceDatabaseId { get; set; }
        
        /// <value>
        /// Number of AWR snapshots uploaded from the Source database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SnapshotsUploaded is required.")]
        [JsonProperty(PropertyName = "snapshotsUploaded")]
        public System.Nullable<decimal> SnapshotsUploaded { get; set; }
        
        /// <value>
        /// The minimum snapshot identifier of the source database for which AWR data is uploaded to AWR Hub.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinSnapshotIdentifier is required.")]
        [JsonProperty(PropertyName = "minSnapshotIdentifier")]
        public System.Nullable<decimal> MinSnapshotIdentifier { get; set; }
        
        /// <value>
        /// The maximum snapshot identifier of the source database for which AWR data is uploaded to AWR Hub.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxSnapshotIdentifier is required.")]
        [JsonProperty(PropertyName = "maxSnapshotIdentifier")]
        public System.Nullable<decimal> MaxSnapshotIdentifier { get; set; }
        
        /// <value>
        /// The time at which the earliest snapshot was generated in the source database for which data is uploaded to AWR Hub. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeFirstSnapshotGenerated is required.")]
        [JsonProperty(PropertyName = "timeFirstSnapshotGenerated")]
        public System.Nullable<System.DateTime> TimeFirstSnapshotGenerated { get; set; }
        
        /// <value>
        /// The time at which the latest snapshot was generated in the source database for which data is uploaded to AWR Hub. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastSnapshotGenerated is required.")]
        [JsonProperty(PropertyName = "timeLastSnapshotGenerated")]
        public System.Nullable<System.DateTime> TimeLastSnapshotGenerated { get; set; }
        
        /// <value>
        /// Number of hours since last AWR snapshots import happened from the Source database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HoursSinceLastImport is required.")]
        [JsonProperty(PropertyName = "hoursSinceLastImport")]
        public System.Double HoursSinceLastImport { get; set; }
        
    }
}
