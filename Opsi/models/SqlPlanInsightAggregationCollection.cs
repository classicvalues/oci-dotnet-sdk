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
    /// SQL plan insights response.
    /// 
    /// </summary>
    public class SqlPlanInsightAggregationCollection 
    {
        
        /// <value>
        /// Unique SQL_ID for a SQL Statement.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlIdentifier is required.")]
        [JsonProperty(PropertyName = "sqlIdentifier")]
        public string SqlIdentifier { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database insight resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseId is required.")]
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        
        /// <value>
        /// List of SQL plan insights.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Insights is required.")]
        [JsonProperty(PropertyName = "insights")]
        public System.Collections.Generic.List<SqlPlanInsights> Insights { get; set; }
        
        /// <value>
        /// List of SQL plan statistics.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<SqlPlanInsightAggregation> Items { get; set; }
        
    }
}
