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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class FilterGroupMembershipDetails 
    {
        
        /// <value>
        /// A resolved principal object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Principal is required.")]
        [JsonProperty(PropertyName = "principal")]
        public Principal Principal { get; set; }
        
        /// <value>
        /// An array of group or dynamic group Ids the resolved principal potentially belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupIds is required.")]
        [JsonProperty(PropertyName = "groupIds")]
        public System.Collections.Generic.List<string> GroupIds { get; set; }
        
    }
}
