/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DevopsService.Models;

namespace Oci.DevopsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/devops/GetMirrorRecord.cs.html">here</a> to see an example of how to use GetMirrorRecord request.
    /// </example>
    public class GetMirrorRecordRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique repository identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "repositoryId")]
        public string RepositoryId { get; set; }
        
        ///
        /// <value>
        /// The field of mirror record type. Only one mirror record type can be provided:
        /// current - The current mirror record.
        /// lastSuccessful - The last successful mirror record.
        /// 
        /// </value>
        ///
        public enum MirrorRecordTypeEnum {
            [EnumMember(Value = "current")]
            Current,
            [EnumMember(Value = "lastSuccessful")]
            LastSuccessful
        };

        /// <value>
        /// The field of mirror record type. Only one mirror record type can be provided:
        /// current - The current mirror record.
        /// lastSuccessful - The last successful mirror record.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MirrorRecordType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "mirrorRecordType")]
        public System.Nullable<MirrorRecordTypeEnum> MirrorRecordType { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
