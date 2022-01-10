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
    
    public class User 
    {
        
        /// <value>
        /// The user's Oracle ID (OCID).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// If the provided password is a one-time password.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOTP is required.")]
        [JsonProperty(PropertyName = "isOTP")]
        public System.Nullable<bool> IsOTP { get; set; }
        
        /// <value>
        /// If mfa is activated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsMfaActivated is required.")]
        [JsonProperty(PropertyName = "isMfaActivated")]
        public System.Nullable<bool> IsMfaActivated { get; set; }
        
        /// <value>
        /// If the user has been mfa verified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsMfaVerified is required.")]
        [JsonProperty(PropertyName = "isMfaVerified")]
        public System.Nullable<bool> IsMfaVerified { get; set; }
        
    }
}
