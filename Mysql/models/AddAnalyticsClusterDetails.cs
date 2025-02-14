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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// DEPRECATED -- please use HeatWave API instead.
    /// Details required to add an Analytics Cluster.
    /// 
    /// </summary>
    public class AddAnalyticsClusterDetails 
    {
        
        /// <value>
        /// The shape determines resources to allocate to the Analytics
        /// Cluster nodes - CPU cores, memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The number of analytics-processing nodes provisioned for the
        /// Analytics Cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterSize is required.")]
        [JsonProperty(PropertyName = "clusterSize")]
        public System.Nullable<int> ClusterSize { get; set; }
        
    }
}
