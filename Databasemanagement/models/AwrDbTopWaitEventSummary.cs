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
    /// A summary of the AWR top wait event data for one event.
    /// </summary>
    public class AwrDbTopWaitEventSummary 
    {
        
        /// <value>
        /// The name of the event.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The wait count per second.
        /// </value>
        [JsonProperty(PropertyName = "waitsPerSec")]
        public System.Double WaitsPerSec { get; set; }
        
        /// <value>
        /// The average wait time per second.
        /// </value>
        [JsonProperty(PropertyName = "avgWaitTimePerSec")]
        public System.Double AvgWaitTimePerSec { get; set; }
        
    }
}
