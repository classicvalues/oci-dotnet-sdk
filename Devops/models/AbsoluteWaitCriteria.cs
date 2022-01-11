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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the absolute wait criteria. You can specify fixed length of wait duration.
    /// </summary>
    public class AbsoluteWaitCriteria : WaitCriteria
    {
        
        /// <value>
        /// The absolute wait duration. An ISO 8601 formatted duration string. Minimum waitDuration should be 5 seconds. Maximum waitDuration can be up to 2 days.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WaitDuration is required.")]
        [JsonProperty(PropertyName = "waitDuration")]
        public string WaitDuration { get; set; }
        
        [JsonProperty(PropertyName = "waitType")]
        private readonly string waitType = "ABSOLUTE_WAIT";
    }
}
