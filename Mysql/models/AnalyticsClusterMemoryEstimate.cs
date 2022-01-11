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
    /// Analytics Cluster memory estimate
    /// that can be used to determine a suitable Analytics Cluster size. For each MySQL user table the estimated memory
    /// footprint when the table is loaded to the Analytics Cluster memory is returned.
    /// 
    /// </summary>
    public class AnalyticsClusterMemoryEstimate 
    {
        
        /// <value>
        /// The OCID of the DB System the Analytics Cluster memory estimate is associated with.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbSystemId is required.")]
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// Current status of the Work Request generating the Analytics Cluster memory estimate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AnalyticsClusterMemoryEstimateStatus> Status { get; set; }
        
        /// <value>
        /// The date and time that the Work Request to generate the Analytics Cluster memory estimate was issued, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc333).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time that the Analytics Cluster memory estimate was generated, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc333).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Collection of schemas with estimated memory footprints for MySQL user tables of each schema
        /// when loaded to Analytics Cluster memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TableSchemas is required.")]
        [JsonProperty(PropertyName = "tableSchemas")]
        public System.Collections.Generic.List<AnalyticsClusterSchemaMemoryEstimate> TableSchemas { get; set; }
        
    }
}
