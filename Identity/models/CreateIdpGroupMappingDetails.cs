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


namespace Oci.IdentityService.Models
{
    
    public class CreateIdpGroupMappingDetails 
    {
        
        /// <value>
        /// The name of the IdP group you want to map.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdpGroupName is required.")]
        [JsonProperty(PropertyName = "idpGroupName")]
        public string IdpGroupName { get; set; }
        
        /// <value>
        /// The OCID of the IAM Service {@link Group}
        /// you want to map to the IdP group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupId is required.")]
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }
        
    }
}
