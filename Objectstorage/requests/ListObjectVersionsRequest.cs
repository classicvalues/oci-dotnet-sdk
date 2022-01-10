/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/objectstorage/ListObjectVersions.cs.html">here</a> to see an example of how to use ListObjectVersions request.
    /// </example>
    public class ListObjectVersionsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Object Storage namespace used for the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// Example: my-new-bucket1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The string to use for matching against the start of object names in a list query.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// Object names returned by a list query must be greater or equal to this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "start")]
        public string Start { get; set; }
        
        /// <value>
        /// Object names returned by a list query must be strictly less than this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "end")]
        public string End { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to return in a paginated
        /// \"List\" call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// When this parameter is set, only objects whose names do not contain the delimiter character
        /// (after an optionally specified prefix) are returned in the objects key of the response body.
        /// Scanned objects whose names contain the delimiter have the part of their name up to the first
        /// occurrence of the delimiter (including the optional prefix) returned as a set of prefixes.
        /// Note that only '/' is a supported delimiter character at this time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "delimiter")]
        public string Delimiter { get; set; }
        
        /// <value>
        /// Object summary by default includes only the 'name' field. Use this parameter to also
        /// include 'size' (object size in bytes), 'etag', 'md5', 'timeCreated' (object creation date and time),
        /// 'timeModified' (object modification date and time), 'storageTier' and 'archivalState' fields.
        /// Specify the value of this parameter as a comma-separated, case-insensitive list of those field names. 
        /// For example 'name,etag,timeCreated,md5,timeModified,storageTier,archivalState'.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public string Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }
        
        /// <value>
        /// Object names returned by a list query must be greater than this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startAfter")]
        public string StartAfter { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from the previous \"List\" call. For important
        /// details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
    }
}
