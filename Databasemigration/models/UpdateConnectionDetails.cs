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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Details to update in a Database Connection resource.
    /// 
    /// </summary>
    public class UpdateConnectionDetails 
    {
        
        /// <value>
        /// Database Connection display name identifier.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the cloud database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        [JsonProperty(PropertyName = "connectDescriptor")]
        public UpdateConnectDescriptor ConnectDescriptor { get; set; }
        
        /// <value>
        /// This name is the distinguished name used while creating the certificate on target database. Not required for source container database connections.
        /// </value>
        [JsonProperty(PropertyName = "certificateTdn")]
        public string CertificateTdn { get; set; }
        
        /// <value>
        /// cwallet.sso containing containing the TCPS/SSL certificate; base64 encoded String. Not required for source container database connections.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tlsWallet")]
        public string TlsWallet { get; set; }
        
        /// <value>
        /// keystore.jks file contents; base64 encoded String. Not required for source container database connections.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tlsKeystore")]
        public string TlsKeystore { get; set; }
        
        [JsonProperty(PropertyName = "sshDetails")]
        public UpdateSshDetails SshDetails { get; set; }
        
        [JsonProperty(PropertyName = "adminCredentials")]
        public UpdateAdminCredentials AdminCredentials { get; set; }
        
        [JsonProperty(PropertyName = "privateEndpoint")]
        public UpdatePrivateEndpoint PrivateEndpoint { get; set; }
        
        [JsonProperty(PropertyName = "vaultDetails")]
        public UpdateVaultDetails VaultDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
