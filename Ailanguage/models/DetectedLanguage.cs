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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Attributes to the detected language. Contains Language Name , Code, and Confidence Score.
    /// </summary>
    public class DetectedLanguage 
    {
        
        /// <value>
        /// Full language name.
        /// Example: English, Hindi, and so on
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Detected language code as per [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) standard.
        /// Example: en, fr, hi etc.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// Score or confidence of detected language code.
        /// Example: 0.9999856066867399
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Score is required.")]
        [JsonProperty(PropertyName = "score")]
        public System.Double Score { get; set; }
        
    }
}
