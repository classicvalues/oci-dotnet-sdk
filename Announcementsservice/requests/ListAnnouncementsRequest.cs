/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AnnouncementsService.Models;

namespace Oci.AnnouncementsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/announcementsservice/ListAnnouncements.cs.html">here</a> to see an example of how to use ListAnnouncements request.
    /// </example>
    public class ListAnnouncementsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment. Because announcements are specific to a tenancy, this is the
        /// OCID of the root compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The type of announcement.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "announcementType")]
        public string AnnouncementType { get; set; }
        
        ///
        /// <value>
        /// The announcement's current lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The announcement's current lifecycle state.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Whether the announcement is displayed as a console banner.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isBanner")]
        public System.Nullable<bool> IsBanner { get; set; }
        
        ///
        /// <value>
        /// The criteria to sort by. You can specify only one sort order.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeOneValue")]
            TimeOneValue,
            [EnumMember(Value = "timeTwoValue")]
            TimeTwoValue,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "referenceTicketNumber")]
            ReferenceTicketNumber,
            [EnumMember(Value = "summary")]
            Summary,
            [EnumMember(Value = "announcementType")]
            AnnouncementType
        };

        /// <value>
        /// The criteria to sort by. You can specify only one sort order.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use. (Sorting by `announcementType` orders the announcements list according to importance.)
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use. (Sorting by `announcementType` orders the announcements list according to importance.)
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The boundary for the earliest `timeOneValue` date on announcements that you want to see.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeOneEarliestTime")]
        public System.Nullable<System.DateTime> TimeOneEarliestTime { get; set; }
        
        /// <value>
        /// The boundary for the latest `timeOneValue` date on announcements that you want to see.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeOneLatestTime")]
        public System.Nullable<System.DateTime> TimeOneLatestTime { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about
        /// a particular request, please provide the complete request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
