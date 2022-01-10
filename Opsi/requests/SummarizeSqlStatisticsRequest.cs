/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/SummarizeSqlStatistics.cs.html">here</a> to see an example of how to use SummarizeSqlStatistics request.
    /// </example>
    public class SummarizeSqlStatisticsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        ///
        /// <value>
        /// Filter by one or more database type.
        /// Possible values are ADW-S, ATP-S, ADW-D, ATP-D, EXTERNAL-PDB, EXTERNAL-NONCDB.
        /// 
        /// </value>
        ///
        public enum DatabaseTypeEnum {
            [EnumMember(Value = "ADW-S")]
            AdwS,
            [EnumMember(Value = "ATP-S")]
            AtpS,
            [EnumMember(Value = "ADW-D")]
            AdwD,
            [EnumMember(Value = "ATP-D")]
            AtpD,
            [EnumMember(Value = "EXTERNAL-PDB")]
            ExternalPdb,
            [EnumMember(Value = "EXTERNAL-NONCDB")]
            ExternalNoncdb
        };

        /// <value>
        /// Filter by one or more database type.
        /// Possible values are ADW-S, ATP-S, ADW-D, ATP-D, EXTERNAL-PDB, EXTERNAL-NONCDB.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<DatabaseTypeEnum> DatabaseType { get; set; }
        
        /// <value>
        /// Optional list of database [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the associated DBaaS entity.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DatabaseId { get; set; }
        
        /// <value>
        /// Optional list of database insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Id { get; set; }
        
        /// <value>
        /// Optional list of exadata insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataInsightId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ExadataInsightId { get; set; }
        
        /// <value>
        /// Filter by one or more cdb name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "cdbName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> CdbName { get; set; }
        
        /// <value>
        /// Filter by one or more hostname.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> HostName { get; set; }
        
        /// <value>
        /// Filter sqls by percentage of db time.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseTimePctGreaterThan")]
        public System.Double DatabaseTimePctGreaterThan { get; set; }
        
        /// <value>
        /// One or more unique SQL_IDs for a SQL Statement.
        /// Example: 6rgjh9bjmy2s7
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sqlIdentifier", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> SqlIdentifier { get; set; }
        
        /// <value>
        /// Specify time period in ISO 8601 format with respect to current time.
        /// Default is last 30 days represented by P30D.
        /// If timeInterval is specified, then timeIntervalStart and timeIntervalEnd will be ignored.
        /// Examples  P90D (last 90 days), P4W (last 4 weeks), P2M (last 2 months), P1Y (last 12 months), . Maximum value allowed is 25 months prior to current time (P25M).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "analysisTimeInterval")]
        public string AnalysisTimeInterval { get; set; }
        
        /// <value>
        /// Analysis start time in UTC in ISO 8601 format(inclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// The minimum allowed value is 2 years prior to the current day.
        /// timeIntervalStart and timeIntervalEnd parameters are used together.
        /// If analysisTimeInterval is specified, this parameter is ignored.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// Analysis end time in UTC in ISO 8601 format(exclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// timeIntervalStart and timeIntervalEnd are used together.
        /// If timeIntervalEnd is not specified, current time is used as timeIntervalEnd.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to
        /// return in a paginated \"List\" call.
        /// For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// Example: 50
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to use when sorting SQL statistics.
        /// Example: databaseTimeInSec
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "databaseTimeInSec")]
            DatabaseTimeInSec,
            [EnumMember(Value = "executionsPerHour")]
            ExecutionsPerHour,
            [EnumMember(Value = "executionsCount")]
            ExecutionsCount,
            [EnumMember(Value = "cpuTimeInSec")]
            CpuTimeInSec,
            [EnumMember(Value = "ioTimeInSec")]
            IoTimeInSec,
            [EnumMember(Value = "inefficientWaitTimeInSec")]
            InefficientWaitTimeInSec,
            [EnumMember(Value = "responseTimeInSec")]
            ResponseTimeInSec,
            [EnumMember(Value = "planCount")]
            PlanCount,
            [EnumMember(Value = "variability")]
            Variability,
            [EnumMember(Value = "averageActiveSessions")]
            AverageActiveSessions,
            [EnumMember(Value = "databaseTimePct")]
            DatabaseTimePct,
            [EnumMember(Value = "inefficiencyInPct")]
            InefficiencyInPct,
            [EnumMember(Value = "changeInCpuTimeInPct")]
            ChangeInCpuTimeInPct,
            [EnumMember(Value = "changeInIoTimeInPct")]
            ChangeInIoTimeInPct,
            [EnumMember(Value = "changeInInefficientWaitTimeInPct")]
            ChangeInInefficientWaitTimeInPct,
            [EnumMember(Value = "changeInResponseTimeInPct")]
            ChangeInResponseTimeInPct,
            [EnumMember(Value = "changeInAverageActiveSessionsInPct")]
            ChangeInAverageActiveSessionsInPct,
            [EnumMember(Value = "changeInExecutionsPerHourInPct")]
            ChangeInExecutionsPerHourInPct,
            [EnumMember(Value = "changeInInefficiencyInPct")]
            ChangeInInefficiencyInPct
        };

        /// <value>
        /// The field to use when sorting SQL statistics.
        /// Example: databaseTimeInSec
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// Filter sqls by one or more performance categories.
        /// 
        /// </value>
        ///
        public enum CategoryEnum {
            [EnumMember(Value = "DEGRADING")]
            Degrading,
            [EnumMember(Value = "VARIANT")]
            Variant,
            [EnumMember(Value = "INEFFICIENT")]
            Inefficient,
            [EnumMember(Value = "CHANGING_PLANS")]
            ChangingPlans,
            [EnumMember(Value = "IMPROVING")]
            Improving,
            [EnumMember(Value = "DEGRADING_VARIANT")]
            DegradingVariant,
            [EnumMember(Value = "DEGRADING_INEFFICIENT")]
            DegradingInefficient,
            [EnumMember(Value = "DEGRADING_CHANGING_PLANS")]
            DegradingChangingPlans,
            [EnumMember(Value = "DEGRADING_INCREASING_IO")]
            DegradingIncreasingIo,
            [EnumMember(Value = "DEGRADING_INCREASING_CPU")]
            DegradingIncreasingCpu,
            [EnumMember(Value = "DEGRADING_INCREASING_INEFFICIENT_WAIT")]
            DegradingIncreasingInefficientWait,
            [EnumMember(Value = "DEGRADING_CHANGING_PLANS_AND_INCREASING_IO")]
            DegradingChangingPlansAndIncreasingIo,
            [EnumMember(Value = "DEGRADING_CHANGING_PLANS_AND_INCREASING_CPU")]
            DegradingChangingPlansAndIncreasingCpu,
            [EnumMember(Value = "DEGRADING_CHANGING_PLANS_AND_INCREASING_INEFFICIENT_WAIT")]
            DegradingChangingPlansAndIncreasingInefficientWait,
            [EnumMember(Value = "VARIANT_INEFFICIENT")]
            VariantInefficient,
            [EnumMember(Value = "VARIANT_CHANGING_PLANS")]
            VariantChangingPlans,
            [EnumMember(Value = "VARIANT_INCREASING_IO")]
            VariantIncreasingIo,
            [EnumMember(Value = "VARIANT_INCREASING_CPU")]
            VariantIncreasingCpu,
            [EnumMember(Value = "VARIANT_INCREASING_INEFFICIENT_WAIT")]
            VariantIncreasingInefficientWait,
            [EnumMember(Value = "VARIANT_CHANGING_PLANS_AND_INCREASING_IO")]
            VariantChangingPlansAndIncreasingIo,
            [EnumMember(Value = "VARIANT_CHANGING_PLANS_AND_INCREASING_CPU")]
            VariantChangingPlansAndIncreasingCpu,
            [EnumMember(Value = "VARIANT_CHANGING_PLANS_AND_INCREASING_INEFFICIENT_WAIT")]
            VariantChangingPlansAndIncreasingInefficientWait,
            [EnumMember(Value = "INEFFICIENT_CHANGING_PLANS")]
            InefficientChangingPlans,
            [EnumMember(Value = "INEFFICIENT_INCREASING_INEFFICIENT_WAIT")]
            InefficientIncreasingInefficientWait,
            [EnumMember(Value = "INEFFICIENT_CHANGING_PLANS_AND_INCREASING_INEFFICIENT_WAIT")]
            InefficientChangingPlansAndIncreasingInefficientWait
        };

        /// <value>
        /// Filter sqls by one or more performance categories.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "category", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<CategoryEnum> Category { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a defined tag matching the value will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagEquals { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a freeform tag matching the value will be returned.
        /// The key for each tag is \"{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same tag name are interpreted as \"OR\".  Values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagEquals { get; set; }
        
        /// <value>
        /// A list of tag existence filters to apply.  Only resources for which the specified defined tags exist will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}.true\" (for checking existence of a defined tag)
        /// or \"{namespace}.true\".  All inputs are case-insensitive.
        /// Currently, only existence (\"true\" at the end) is supported. Absence (\"false\" at the end) is not supported.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagExists", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagExists { get; set; }
        
        /// <value>
        /// A list of tag existence filters to apply.  Only resources for which the specified freeform tags exist the value will be returned.
        /// The key for each tag is \"{tagName}.true\".  All inputs are case-insensitive.
        /// Currently, only existence (\"true\" at the end) is supported. Absence (\"false\" at the end) is not supported.
        /// Multiple values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagExists", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagExists { get; set; }
        
        /// <value>
        /// A flag to search all resources within a given compartment and all sub-compartments.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
    }
}
