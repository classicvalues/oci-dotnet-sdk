/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// entity object
    /// </summary>
    public class Entity 
    {
        
        /// <value>
        /// The number of Unicode code points preceding this entity in the submitted text.
        /// </value>
        [JsonProperty(PropertyName = "offset")]
        public System.Nullable<int> Offset { get; set; }
        
        /// <value>
        /// Length of entity text
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<int> Length { get; set; }
        
        /// <value>
        /// Entity text like name of person, location, and so on.
        /// </value>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// Type of entity text like PER, LOC, GPE and NOPE.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// This flag is to indicate if it is PII entity or not.
        /// </value>
        [JsonProperty(PropertyName = "isPii")]
        public System.Nullable<bool> IsPii { get; set; }
        
        /// <value>
        /// Score or confidence of extracted entity type.
        /// Example: 0.9999856066867399
        /// </value>
        [JsonProperty(PropertyName = "score")]
        public System.Double Score { get; set; }
        
    }
}
