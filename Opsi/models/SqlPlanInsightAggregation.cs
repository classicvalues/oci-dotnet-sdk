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
    /// SQL execution plan Performance statistics.
    /// </summary>
    public class SqlPlanInsightAggregation 
    {
        
        /// <value>
        /// Plan hash value for the SQL Execution Plan
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanHash is required.")]
        [JsonProperty(PropertyName = "planHash")]
        public System.Nullable<long> PlanHash { get; set; }
        
        /// <value>
        /// IO Time in seconds
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IoTimeInSec is required.")]
        [JsonProperty(PropertyName = "ioTimeInSec")]
        public System.Double IoTimeInSec { get; set; }
        
        /// <value>
        /// CPU Time in seconds
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuTimeInSec is required.")]
        [JsonProperty(PropertyName = "cpuTimeInSec")]
        public System.Double CpuTimeInSec { get; set; }
        
        /// <value>
        /// Inefficient Wait Time in seconds
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InefficientWaitTimeInSec is required.")]
        [JsonProperty(PropertyName = "inefficientWaitTimeInSec")]
        public System.Double InefficientWaitTimeInSec { get; set; }
        
        /// <value>
        /// Total number of executions
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionsCount is required.")]
        [JsonProperty(PropertyName = "executionsCount")]
        public System.Nullable<long> ExecutionsCount { get; set; }
        
    }
}
