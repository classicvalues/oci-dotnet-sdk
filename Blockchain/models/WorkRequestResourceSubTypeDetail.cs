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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// SubType information for a work request resource.
    /// </summary>
    public class WorkRequestResourceSubTypeDetail 
    {
        
        /// <value>
        /// Subtype of the work request resource like osn or peer.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubType is required.")]
        [JsonProperty(PropertyName = "subType")]
        public string SubType { get; set; }
        
        /// <value>
        /// The identifier of the resource subType.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubTypeKey is required.")]
        [JsonProperty(PropertyName = "subTypeKey")]
        public string SubTypeKey { get; set; }
                ///
        /// <value>
        /// Status of the resource subType, as a result of the work tracked in this work request.
        /// A resource subType would be CREATED, UPDATED or DELETED, after the work request is completed.
        /// 
        /// </value>
        ///
        public enum SubTypeStatusEnum {
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "UPDATED")]
            Updated,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// Status of the resource subType, as a result of the work tracked in this work request.
        /// A resource subType would be CREATED, UPDATED or DELETED, after the work request is completed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubTypeStatus is required.")]
        [JsonProperty(PropertyName = "subTypeStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SubTypeStatusEnum> SubTypeStatus { get; set; }
        
    }
}
