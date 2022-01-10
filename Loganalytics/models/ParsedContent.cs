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
    /// Parsed representation of the log file.
    /// </summary>
    public class ParsedContent 
    {
        
        /// <value>
        /// List of field names.
        /// </value>
        [JsonProperty(PropertyName = "fieldNames")]
        public System.Collections.Generic.List<string> FieldNames { get; set; }
        
        /// <value>
        /// List of field display names.
        /// </value>
        [JsonProperty(PropertyName = "fieldDisplayNames")]
        public System.Collections.Generic.List<string> FieldDisplayNames { get; set; }
        
        /// <value>
        /// Parsed field values.
        /// </value>
        [JsonProperty(PropertyName = "parsedFieldValues")]
        public System.Collections.Generic.List<ParsedField> ParsedFieldValues { get; set; }
        
        /// <value>
        /// Sample log entries picked up from the given file for validation.
        /// </value>
        [JsonProperty(PropertyName = "logContent")]
        public string LogContent { get; set; }
        
        /// <value>
        /// Sample Size taken for validation.
        /// </value>
        [JsonProperty(PropertyName = "sampleSize")]
        public System.Nullable<int> SampleSize { get; set; }
        
        /// <value>
        /// Match Status.
        /// </value>
        [JsonProperty(PropertyName = "matchStatus")]
        public string MatchStatus { get; set; }
        
    }
}
