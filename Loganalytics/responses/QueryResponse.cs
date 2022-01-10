/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Responses
{
    public class QueryResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. When you contact Oracle about a specific request, provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// For pagination of a list of items. When paging through a list, if this header appears in the response,
        /// then additional items may be available on the next page of the list. Include this value as the `page` parameter for the
        /// subsequent request to get the next batch of items.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page-id")]
        public string OpcNextPageId { get; set; }


        /// <value>
        /// For pagination of a list of items. When paging through a list, if this header appears in the response,
        /// then additional items may be available on the previous page of the list. Include this value as the `page` parameter for the
        /// subsequent request to get the previous batch of items.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-prev-page-id")]
        public string OpcPrevPageId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the asynchronous request. You can use this to query status of the asynchronous operation.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-work-request-id")]
        public string OpcWorkRequestId { get; set; }


        /// <value>
        /// URI to entity or work request created.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "location")]
        public string Location { get; set; }

        /// <value>
        /// The returned QueryAggregation instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public QueryAggregation QueryAggregation { get; set; }

    }
}
