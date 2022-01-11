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
    /// The database storage metric values.
    /// </summary>
    public class DatabaseStorageAggregateMetrics 
    {
        
        [JsonProperty(PropertyName = "storageAllocated")]
        public MetricDataPoint StorageAllocated { get; set; }
        
        [JsonProperty(PropertyName = "storageUsed")]
        public MetricDataPoint StorageUsed { get; set; }
        
        /// <value>
        /// A list of the storage metrics grouped by TableSpace for a specific database.
        /// </value>
        [JsonProperty(PropertyName = "storageUsedByTableSpace")]
        public System.Collections.Generic.List<MetricDataPoint> StorageUsedByTableSpace { get; set; }
        
    }
}
