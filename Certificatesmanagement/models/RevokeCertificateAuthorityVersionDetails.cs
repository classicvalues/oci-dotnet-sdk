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
    /// The details of the request to revoke a certificate authority (CA) version.
    /// </summary>
    public class RevokeCertificateAuthorityVersionDetails 
    {
        
        /// <value>
        /// The reason the certificate or certificate authority was revoked.
        /// </value>
        [JsonProperty(PropertyName = "revocationReason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RevocationReason> RevocationReason { get; set; }
        
    }
}
