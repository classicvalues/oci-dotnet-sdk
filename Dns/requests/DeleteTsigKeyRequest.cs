/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dns/DeleteTsigKey.cs.html">here</a> to see an example of how to use DeleteTsigKey request.
    /// </example>
    public class DeleteTsigKeyRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the target TSIG key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TsigKeyId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "tsigKeyId")]
        public string TsigKeyId { get; set; }
        
        /// <value>
        /// The `If-Match` header field makes the request method conditional on the
        /// existence of at least one current representation of the target resource,
        /// when the field-value is `*`, or having a current representation of the
        /// target resource that has an entity-tag matching a member of the list of
        /// entity-tags provided in the field-value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-Match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The `If-Unmodified-Since` header field makes the request method
        /// conditional on the selected representation's last modification date being
        /// earlier than or equal to the date provided in the field-value.  This
        /// field accomplishes the same purpose as If-Match for cases where the user
        /// agent does not have an entity-tag for the representation.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-Unmodified-Since")]
        public string IfUnmodifiedSince { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need
        /// to contact Oracle about a particular request, please provide
        /// the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Specifies to operate only on resources that have a matching DNS scope.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scope")]
        public System.Nullable<Scope> Scope { get; set; }
    }
}
