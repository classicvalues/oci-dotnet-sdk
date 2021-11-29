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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Object containing the details of a line in a file.
    /// </summary>
    public class FileLineDetails 
    {
        
        /// <value>
        /// The line number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LineNumber is required.")]
        [JsonProperty(PropertyName = "lineNumber")]
        public System.Nullable<int> LineNumber { get; set; }
        
        /// <value>
        /// The content of the line.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LineContent is required.")]
        [JsonProperty(PropertyName = "lineContent")]
        public string LineContent { get; set; }
        
    }
}
