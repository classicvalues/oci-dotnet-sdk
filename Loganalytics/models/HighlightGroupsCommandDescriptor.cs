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
    /// Command descriptor for querylanguage HIGHLIGHTGROUPS command.
    /// 
    /// </summary>
    public class HighlightGroupsCommandDescriptor : AbstractCommandDescriptor
    {
        
        /// <value>
        /// User specified color to highlight matches with if found.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
        
        /// <value>
        /// User specified priority assigned to highlighted matches if found.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }
        
        /// <value>
        /// List of fields to search for terms or phrases to highlight.  If not specified all string fields are scanned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "matchOnly")]
        public System.Collections.Generic.List<string> MatchOnly { get; set; }
        
        /// <value>
        /// List of fields to search for terms or phrases to highlight.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<string> Fields { get; set; }
        
        /// <value>
        /// List of terms or phrases to highlight if found.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keywords")]
        public System.Collections.Generic.List<string> Keywords { get; set; }
        
        /// <value>
        /// List of subQueries specified as highlightgroups command arguments
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subQueries")]
        public System.Collections.Generic.List<ParseQueryOutput> SubQueries { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "HIGHLIGHT_GROUPS";
    }
}
