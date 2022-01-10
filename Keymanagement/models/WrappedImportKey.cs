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


namespace Oci.KeymanagementService.Models
{
    
    public class WrappedImportKey 
    {
        
        /// <value>
        /// The key material to import, wrapped by the vault's RSA public wrapping key and base64-encoded.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyMaterial is required.")]
        [JsonProperty(PropertyName = "keyMaterial")]
        public string KeyMaterial { get; set; }
                ///
        /// <value>
        /// The wrapping mechanism to use during key import.
        /// `RSA_OAEP_AES_SHA256` invokes the RSA AES key wrap mechanism, which generates a temporary AES key. The temporary AES key is wrapped
        /// by the vault's RSA public wrapping key, creating a wrapped temporary AES key. The temporary AES key is also used to wrap the private key material.
        /// The wrapped temporary AES key and the wrapped exportable key material are concatenated, producing concatenated blob output that jointly represents them.
        /// `RSA_OAEP_SHA256` means that the exportable key material is wrapped by the vault's RSA public wrapping key.
        /// 
        /// </value>
        ///
        public enum WrappingAlgorithmEnum {
            [EnumMember(Value = "RSA_OAEP_SHA256")]
            RsaOaepSha256,
            [EnumMember(Value = "RSA_OAEP_AES_SHA256")]
            RsaOaepAesSha256
        };

        /// <value>
        /// The wrapping mechanism to use during key import.
        /// `RSA_OAEP_AES_SHA256` invokes the RSA AES key wrap mechanism, which generates a temporary AES key. The temporary AES key is wrapped
        /// by the vault's RSA public wrapping key, creating a wrapped temporary AES key. The temporary AES key is also used to wrap the private key material.
        /// The wrapped temporary AES key and the wrapped exportable key material are concatenated, producing concatenated blob output that jointly represents them.
        /// `RSA_OAEP_SHA256` means that the exportable key material is wrapped by the vault's RSA public wrapping key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WrappingAlgorithm is required.")]
        [JsonProperty(PropertyName = "wrappingAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<WrappingAlgorithmEnum> WrappingAlgorithm { get; set; }
        
    }
}
