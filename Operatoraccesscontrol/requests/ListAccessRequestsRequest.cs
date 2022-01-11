/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OperatoraccesscontrolService.Models;

namespace Oci.OperatoraccesscontrolService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/operatoraccesscontrol/ListAccessRequests.cs.html">here</a> to see an example of how to use ListAccessRequests request.
    /// </example>
    public class ListAccessRequestsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The ID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given ResourceName.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// A filter to return only lists of resources that match the entire given service type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// A filter to return only resources whose lifecycleState matches the given AccessRequest lifecycleState.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<AccessRequestLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Query start time in UTC in ISO 8601 format(inclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// timeIntervalStart and timeIntervalEnd parameters are used together.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Query start time in UTC in ISO 8601 format(inclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// timeIntervalStart and timeIntervalEnd parameters are used together.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending. If no value is specified timeCreated is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "displayName")]
            DisplayName
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending. If no value is specified timeCreated is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
