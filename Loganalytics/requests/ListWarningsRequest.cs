/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/loganalytics/ListWarnings.cs.html">here</a> to see an example of how to use ListWarnings request.
    /// </example>
    public class ListWarningsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Logging Analytics namespace used for the request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The ID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        ///
        /// <value>
        /// The warning state used for filtering.  A value of SUPPRESSED will return only
        /// suppressed warnings, a value of UNSUPPRESSED will return only unsuppressed
        /// warnings, and a value of ALL will return all warnings regardless of their
        /// suppression state.  Default is UNSUPPRESSED.
        /// 
        /// </value>
        ///
        public enum WarningStateEnum {
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "SUPPRESSED")]
            Suppressed,
            [EnumMember(Value = "UNSUPPRESSED")]
            Unsuppressed
        };

        /// <value>
        /// The warning state used for filtering.  A value of SUPPRESSED will return only
        /// suppressed warnings, a value of UNSUPPRESSED will return only unsuppressed
        /// warnings, and a value of ALL will return all warnings regardless of their
        /// suppression state.  Default is UNSUPPRESSED.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "warningState")]
        public System.Nullable<WarningStateEnum> WarningState { get; set; }
        
        /// <value>
        /// The source name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// The source pattern used for filtering.  Only warnings associated with a source with the
        /// specified pattern will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourcePattern")]
        public string SourcePattern { get; set; }
        
        /// <value>
        /// warning message query parameter
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "warningMessage")]
        public string WarningMessage { get; set; }
        
        /// <value>
        /// The entity name used for filtering.  Only warnings associated with an entity with the
        /// specified name will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// The entity type used for filtering.  Only associations on an entity with the
        /// specified type will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The warning type query parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "warningType")]
        public string WarningType { get; set; }
        
        /// <value>
        /// A flag indicating whether to filter warnings based on source display name or on warning level.
        /// A value of true will filter based on warning level (rule, source, or pattern), while a
        /// value of false will filter based on source display name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isNoSource")]
        public System.Nullable<bool> IsNoSource { get; set; }
        
        /// <value>
        /// The warning start date query parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startTime")]
        public string StartTime { get; set; }
        
        /// <value>
        /// The warning end date query parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endTime")]
        public string EndTime { get; set; }
        
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
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
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
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The attribute used to sort the returned warnings
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "EntityType")]
            EntityType,
            [EnumMember(Value = "SourceName")]
            SourceName,
            [EnumMember(Value = "PatternText")]
            PatternText,
            [EnumMember(Value = "FirstReported")]
            FirstReported,
            [EnumMember(Value = "WarningMessage")]
            WarningMessage,
            [EnumMember(Value = "Host")]
            Host,
            [EnumMember(Value = "EntityName")]
            EntityName,
            [EnumMember(Value = "InitialWarningDate")]
            InitialWarningDate
        };

        /// <value>
        /// The attribute used to sort the returned warnings
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
