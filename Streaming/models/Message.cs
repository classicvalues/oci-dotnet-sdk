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


namespace Oci.StreamingService.Models
{
    /// <summary>
    /// A message in a stream.
    /// </summary>
    public class Message 
    {
        
        /// <value>
        /// The name of the stream that the message belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Stream is required.")]
        [JsonProperty(PropertyName = "stream")]
        public string Stream { get; set; }
        
        /// <value>
        /// The ID of the partition where the message is stored.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Partition is required.")]
        [JsonProperty(PropertyName = "partition")]
        public string Partition { get; set; }
        
        /// <value>
        /// The key associated with the message, expressed as a byte array.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public System.Byte[] Key { get; set; }
        
        /// <value>
        /// The value associated with the message, expressed as a byte array.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public System.Byte[] Value { get; set; }
        
        /// <value>
        /// The offset of the message, which uniquely identifies it within the partition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Offset is required.")]
        [JsonProperty(PropertyName = "offset")]
        public System.Nullable<long> Offset { get; set; }
        
        /// <value>
        /// The timestamp indicating when the server appended the message to the stream.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
    }
}
