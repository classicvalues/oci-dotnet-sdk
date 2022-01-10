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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Parameters for GoldenGate Extract processes.
    /// 
    /// </summary>
    public class CreateExtract 
    {
        
        /// <value>
        /// Extract performance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "performanceProfile")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExtractPerformanceProfile> PerformanceProfile { get; set; }
        
        /// <value>
        /// Length of time (in seconds) that a transaction can be open before Extract generates a warning message that the transaction is long-running.
        /// If not specified, Extract will not generate a warning on long-running transactions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "longTransDuration")]
        public System.Nullable<int> LongTransDuration { get; set; }
        
    }
}
