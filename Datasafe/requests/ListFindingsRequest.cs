/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatasafeService.Models;

namespace Oci.DatasafeService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListFindings.cs.html">here</a> to see an example of how to use ListFindings request.
    /// </example>
    public class ListFindingsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the security assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityAssessmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "securityAssessmentId")]
        public string SecurityAssessmentId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// A filter to return only findings of a particular risk level.
        /// </value>
        ///
        public enum SeverityEnum {
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "EVALUATE")]
            Evaluate,
            [EnumMember(Value = "ADVISORY")]
            Advisory,
            [EnumMember(Value = "PASS")]
            Pass
        };

        /// <value>
        /// A filter to return only findings of a particular risk level.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "severity")]
        public System.Nullable<SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of items to return per page in a paginated \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Default is false.
        /// When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned. Depends on the 'accessLevel' setting.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        ///
        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "ACCESSIBLE")]
            Accessible
        };

        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// Each finding has a key. This key is same for the finding across targets
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "findingKey")]
        public string FindingKey { get; set; }
    }
}
