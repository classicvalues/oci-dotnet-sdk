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
    
    public class UpdateOAuth2ClientCredentialDetails 
    {
        
        /// <value>
        /// Description of the oauth credential to help user differentiate them.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Allowed scopes for the given oauth credential.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scopes is required.")]
        [JsonProperty(PropertyName = "scopes")]
        public System.Collections.Generic.List<FullyQualifiedScope> Scopes { get; set; }
        
        /// <value>
        /// Indicate if the password to be reset or not in the update.
        /// </value>
        [JsonProperty(PropertyName = "isResetPassword")]
        public System.Nullable<bool> IsResetPassword { get; set; }
        
    }
}
