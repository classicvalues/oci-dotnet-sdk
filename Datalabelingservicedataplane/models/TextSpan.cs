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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// A wrapper class for offset and length, which together represent a span of text in a text document.
    /// </summary>
    public class TextSpan 
    {
        
        /// <value>
        /// Offset of the selected text within the entire text.
        /// </value>
        [JsonProperty(PropertyName = "offset")]
        public System.Nullable<decimal> Offset { get; set; }
        
        /// <value>
        /// Length of the selected text.
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<decimal> Length { get; set; }
        
    }
}
