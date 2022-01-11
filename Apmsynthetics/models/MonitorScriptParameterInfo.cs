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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Details of the script parameters in the monitor.
    /// isOverwritten specifies that the script parameters are overwritten in the monitor.
    /// If the user overwrites the parameter value in the monitor, then the overwritten values will be used to run the monitor.
    /// 
    /// </summary>
    public class MonitorScriptParameterInfo 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitorScriptParameter is required.")]
        [JsonProperty(PropertyName = "monitorScriptParameter")]
        public MonitorScriptParameter MonitorScriptParameter { get; set; }
        
        /// <value>
        /// Describes if  the parameter value is secret and should be kept confidential.
        /// isSecret is specified in either CreateScript or UpdateScript API.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSecret is required.")]
        [JsonProperty(PropertyName = "isSecret")]
        public System.Nullable<bool> IsSecret { get; set; }
        
        /// <value>
        /// If parameter value is default or overwritten.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOverwritten is required.")]
        [JsonProperty(PropertyName = "isOverwritten")]
        public System.Nullable<bool> IsOverwritten { get; set; }
        
    }
}
