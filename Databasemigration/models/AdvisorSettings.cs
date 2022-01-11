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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Optional Pre-Migration advisor settings.
    /// 
    /// </summary>
    public class AdvisorSettings 
    {
        
        /// <value>
        /// True to skip the Pre-Migration Advisor execution. Default is false.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSkipAdvisor")]
        public System.Nullable<bool> IsSkipAdvisor { get; set; }
        
        /// <value>
        /// True to not interrupt migration execution due to Pre-Migration Advisor errors. Default is false.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isIgnoreErrors")]
        public System.Nullable<bool> IsIgnoreErrors { get; set; }
        
    }
}
