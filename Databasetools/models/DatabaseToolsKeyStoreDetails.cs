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


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// The details of the key store.
    /// </summary>
    public class DatabaseToolsKeyStoreDetails 
    {
        
        /// <value>
        /// The key store type.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KeyStoreType> KeyStoreType { get; set; }
        
        [JsonProperty(PropertyName = "keyStoreContent")]
        public DatabaseToolsKeyStoreContentDetails KeyStoreContent { get; set; }
        
        [JsonProperty(PropertyName = "keyStorePassword")]
        public DatabaseToolsKeyStorePasswordDetails KeyStorePassword { get; set; }
        
    }
}
