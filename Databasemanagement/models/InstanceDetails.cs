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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of the Oracle Real Application Clusters (Oracle RAC) database instance.
    /// </summary>
    public class InstanceDetails 
    {
        
        /// <value>
        /// The ID of the Oracle RAC database instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public System.Nullable<int> Id { get; set; }
        
        /// <value>
        /// The name of the Oracle RAC database instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the host of the Oracle RAC database instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
                ///
        /// <value>
        /// The status of the Oracle RAC database instance.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The status of the Oracle RAC database instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
    }
}
