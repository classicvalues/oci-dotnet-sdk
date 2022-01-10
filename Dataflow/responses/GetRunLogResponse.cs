/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DataflowService.Models;

namespace Oci.DataflowService.Responses
{
    public class GetRunLogResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique Oracle assigned identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// For optimistic concurrency control.
        /// See [ETags for Optimistic Concurrency Control](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#eleven).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Indicates the size of the data as described in RFC 2616, section 14.13.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }


        /// <value>
        /// Specifies the media type of the underlying data as described in RFC 2616, section 14.17.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-type")]
        public string ContentType { get; set; }


        /// <value>
        /// Indicates the encoding of the data, as described in RFC 2616, section 14.11.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-encoding")]
        public string ContentEncoding { get; set; }


        /// <value>
        /// The user-defined metadata for the log.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-meta-")]
        public System.Collections.Generic.Dictionary<string, string> OpcMeta { get; set; }

        /// <value>
        /// The returned System.IO.Stream instance.  Caller must always close the stream to avoid holding resources.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream InputStream { get; set; }

    }
}
