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
    /// Summary of quick pick query objects that contains the quick pick queries.
    /// 
    /// </summary>
    public class QuickPickSummary 
    {
        
        /// <value>
        /// Quick pick name for the query.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QuickPickName is required.")]
        [JsonProperty(PropertyName = "quickPickName")]
        public string QuickPickName { get; set; }
        
        /// <value>
        /// Query for the quick pick.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QuickPickQuery is required.")]
        [JsonProperty(PropertyName = "quickPickQuery")]
        public string QuickPickQuery { get; set; }
        
    }
}
