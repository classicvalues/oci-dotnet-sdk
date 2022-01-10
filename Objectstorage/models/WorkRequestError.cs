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


namespace Oci.ObjectstorageService.Models
{
    
    public class WorkRequestError 
    {
        
        /// <value>
        /// A machine-usable code for the error that occurred. For the list of error codes,
        /// see [API Errors](https://docs.cloud.oracle.com/Content/API/References/apierrors.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// A human-readable description of the issue that produced the error.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The time the error occurred.
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
    }
}
