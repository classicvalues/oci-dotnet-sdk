/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Requests
{
    public class ListZonesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment the resource belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need
        /// to contact Oracle about a particular request, please provide
        /// the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a page of the collection.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<long> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// A case-sensitive filter for zone names.
        /// Will match any zone with a name that equals the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Search by zone name.
        /// Will match any zone whose name (case-insensitive) contains the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "nameContains")]
        public string NameContains { get; set; }
        
        ///
        /// <value>
        /// Search by zone type, `PRIMARY` or `SECONDARY`.
        /// Will match any zone whose type equals the provided value.
        /// 
        /// </value>
        ///
        public enum ZoneTypeEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "SECONDARY")]
            Secondary
        };

        /// <value>
        /// Search by zone type, `PRIMARY` or `SECONDARY`.
        /// Will match any zone whose type equals the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "zoneType")]
        public System.Nullable<ZoneTypeEnum> ZoneType { get; set; }
        
        /// <value>
        /// An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states
        /// all returned resources were created on or after the indicated time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states
        /// all returned resources were created before the indicated time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }
        
        ///
        /// <value>
        /// The state of a resource.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The state of a resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        ///
        /// <value>
        /// The field by which to sort zones.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "zoneType")]
            ZoneType,
            [EnumMember(Value = "timeCreated")]
            TimeCreated
        };

        /// <value>
        /// The field by which to sort zones.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The order to sort the resources.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// Specifies to operate only on resources that have a matching DNS scope.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scope")]
        public System.Nullable<Scope> Scope { get; set; }
        
        /// <value>
        /// The OCID of the view the resource is associated with.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "viewId")]
        public string ViewId { get; set; }
    }
}