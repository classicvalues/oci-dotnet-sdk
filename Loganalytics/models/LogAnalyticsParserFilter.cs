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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsParserFilter
    /// </summary>
    public class LogAnalyticsParserFilter 
    {
        
        /// <value>
        /// The parser filter unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        [JsonProperty(PropertyName = "parser")]
        public LogAnalyticsParser Parser { get; set; }
        
        /// <value>
        /// The agent version.
        /// </value>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }
        
        /// <value>
        /// A flag idicating whether or not hte filter is currently being used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInUse")]
        public System.Nullable<long> IsInUse { get; set; }
        
        /// <value>
        /// The operating system.
        /// </value>
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; set; }
        
        /// <value>
        /// The parser unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "parserId")]
        public System.Nullable<long> ParserId { get; set; }
        
        /// <value>
        /// The version.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
    }
}
