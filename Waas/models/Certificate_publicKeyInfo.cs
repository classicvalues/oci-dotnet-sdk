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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// Information about the public key and the algorithm used by the public key.
    /// </summary>
    public class Certificate_publicKeyInfo 
    {
        
        /// <value>
        /// The algorithm identifier and parameters for the public key.
        /// </value>
        [JsonProperty(PropertyName = "algorithm")]
        public string Algorithm { get; set; }
        
        /// <value>
        /// The private key exponent.
        /// </value>
        [JsonProperty(PropertyName = "exponent")]
        public System.Nullable<int> Exponent { get; set; }
        
        /// <value>
        /// The number of bits in a key used by a cryptographic algorithm.
        /// </value>
        [JsonProperty(PropertyName = "keySize")]
        public System.Nullable<int> KeySize { get; set; }
        
    }
}
