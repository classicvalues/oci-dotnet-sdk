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
    /// Command descriptor for querylanguage CLASSIFY command.
    /// 
    /// </summary>
    public class ClassifyCommandDescriptor : AbstractCommandDescriptor
    {
        
        /// <value>
        /// Value specified in CLASSIFY command in queryString if set limits the results returned to top N.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topCount")]
        public System.Nullable<int> TopCount { get; set; }
        
        /// <value>
        /// Value specified in CLASSIFY command in queryString if set limits the results returned to bottom N.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bottomCount")]
        public System.Nullable<int> BottomCount { get; set; }
        
        /// <value>
        /// Fields specified in CLASSIFY command in queryString if set include / exclude fields in correlate results.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "correlate")]
        public System.Collections.Generic.List<FieldsAddRemoveField> Correlate { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "CLASSIFY";
    }
}
