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


namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details of the configuration for creating a certificate based on the keys from an imported certificate.
    /// </summary>
    public class CreateCertificateByImportingConfigDetails : CreateCertificateConfigDetails
    {
        
        /// <value>
        /// The certificate chain (in PEM format) for the imported certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertChainPem is required.")]
        [JsonProperty(PropertyName = "certChainPem")]
        public string CertChainPem { get; set; }
        
        /// <value>
        /// The private key (in PEM format) for the imported certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivateKeyPem is required.")]
        [JsonProperty(PropertyName = "privateKeyPem")]
        public string PrivateKeyPem { get; set; }
        
        /// <value>
        /// The certificate (in PEM format) for the imported certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificatePem is required.")]
        [JsonProperty(PropertyName = "certificatePem")]
        public string CertificatePem { get; set; }
        
        /// <value>
        /// An optional passphrase for the private key.
        /// </value>
        [JsonProperty(PropertyName = "privateKeyPemPassphrase")]
        public string PrivateKeyPemPassphrase { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "IMPORTED";
    }
}
