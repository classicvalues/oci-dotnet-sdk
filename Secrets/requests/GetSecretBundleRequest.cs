/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.SecretsService.Models;

namespace Oci.SecretsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/secrets/GetSecretBundle.cs.html">here</a> to see an example of how to use GetSecretBundle request.
    /// </example>
    public class GetSecretBundleRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the secret.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "secretId")]
        public string SecretId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The version number of the secret.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "versionNumber")]
        public System.Nullable<long> VersionNumber { get; set; }
        
        /// <value>
        /// The name of the secret. (This might be referred to as the name of the secret version. Names are unique across the different versions of a secret.)
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "secretVersionName")]
        public string SecretVersionName { get; set; }
        
        ///
        /// <value>
        /// The rotation state of the secret version.
        /// </value>
        ///
        public enum StageEnum {
            [EnumMember(Value = "CURRENT")]
            Current,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "LATEST")]
            Latest,
            [EnumMember(Value = "PREVIOUS")]
            Previous,
            [EnumMember(Value = "DEPRECATED")]
            Deprecated
        };

        /// <value>
        /// The rotation state of the secret version.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "stage")]
        public System.Nullable<StageEnum> Stage { get; set; }
    }
}
