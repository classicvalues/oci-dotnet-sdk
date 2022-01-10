/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DevopsService.Models;

namespace Oci.DevopsService.Responses
{
    public class GetObjectContentResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// Content type refers to content of a file which is transferred via HTTP
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Type")]
        public string ContentType { get; set; }


        /// <value>
        /// The Content-Disposition response-header field has been proposed as a means for the origin server to suggest a default filename if the user requests that the content is saved to a file.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Disposition")]
        public string ContentDisposition { get; set; }

        /// <value>
        /// The returned System.IO.Stream instance.  Caller must always close the stream to avoid holding resources.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream InputStream { get; set; }

    }
}
