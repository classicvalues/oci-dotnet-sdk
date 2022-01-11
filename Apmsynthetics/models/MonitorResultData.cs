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
    /// Details of the monitor result data.
    /// </summary>
    public class MonitorResultData 
    {
        
        /// <value>
        /// Name of the data.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Data content in byte format.
        /// Example: Zip or Screenshot.
        /// </value>
        [JsonProperty(PropertyName = "byteContent")]
        public System.Byte[] ByteContent { get; set; }
        
        /// <value>
        /// Data content in string format.
        /// Example: HAR.
        /// </value>
        [JsonProperty(PropertyName = "stringContent")]
        public string StringContent { get; set; }
        
        /// <value>
        /// The time when the data was generated, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// Example: 2020-02-13T22:47:12.613Z
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
    }
}
