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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the subcategory associated with the support ticket.
    /// </summary>
    public class SubCategory 
    {
        
        /// <value>
        /// Unique identifier for the subcategory.
        /// </value>
        [JsonProperty(PropertyName = "subCategoryKey")]
        public string SubCategoryKey { get; set; }
        
        /// <value>
        /// The name of the subcategory. For example, `Backup Count` or `Custom Image Count`.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
