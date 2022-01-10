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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Definition of a tag which is a key value pair.
    /// 
    /// </summary>
    public class Tag 
    {
        
        /// <value>
        /// Key that specifies the tag name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagName is required.")]
        [JsonProperty(PropertyName = "tagName")]
        public string TagName { get; set; }
        
        /// <value>
        /// Value associated with the tag key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagValue is required.")]
        [JsonProperty(PropertyName = "tagValue")]
        public string TagValue { get; set; }
        
    }
}
