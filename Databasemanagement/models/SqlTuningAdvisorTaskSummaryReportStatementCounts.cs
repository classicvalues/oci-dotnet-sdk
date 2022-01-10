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
    /// The statement counts data for the SQL Tuning Advisor summary report.
    /// </summary>
    public class SqlTuningAdvisorTaskSummaryReportStatementCounts 
    {
        
        /// <value>
        /// The count of distinct SQL statements.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DistinctSql is required.")]
        [JsonProperty(PropertyName = "distinctSql")]
        public System.Nullable<int> DistinctSql { get; set; }
        
        /// <value>
        /// The total count of SQL statements.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSql is required.")]
        [JsonProperty(PropertyName = "totalSql")]
        public System.Nullable<int> TotalSql { get; set; }
        
        /// <value>
        /// The count of distinct SQL statements with findings.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FindingCount is required.")]
        [JsonProperty(PropertyName = "findingCount")]
        public System.Nullable<int> FindingCount { get; set; }
        
        /// <value>
        /// The count of distinct SQL statements with errors.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorCount is required.")]
        [JsonProperty(PropertyName = "errorCount")]
        public System.Nullable<int> ErrorCount { get; set; }
        
    }
}
