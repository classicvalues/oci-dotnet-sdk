/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.MonitoringService.Models;

namespace Oci.MonitoringService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/monitoring/SummarizeMetricsData.cs.html">here</a> to see an example of how to use SummarizeMetricsData request.
    /// </example>
    public class SummarizeMetricsDataRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the
        /// resources monitored by the metric that you are searching for. Use tenancyId to search in
        /// the root compartment.
        /// <br/>
        /// Example: ocid1.compartment.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The dimensions used to filter for metrics.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SummarizeMetricsDataDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public SummarizeMetricsDataDetails SummarizeMetricsDataDetails { get; set; }
        
        /// <value>
        /// Customer part of the request identifier token. If you need to contact Oracle about a particular
        /// request, please provide the complete request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// When true, returns resources from all compartments and subcompartments. The parameter can
        /// only be set to true when compartmentId is the tenancy OCID (the tenancy is the root compartment).
        /// A true value requires the user to have tenancy-level permissions. If this requirement is not met,
        /// then the call is rejected. When false, returns resources from only the compartment specified in
        /// compartmentId. Default is false.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
    }
}
