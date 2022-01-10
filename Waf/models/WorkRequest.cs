/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.WafService.Models
{
    /// <summary>
    /// A description of WorkRequest status
    /// </summary>
    public class WorkRequest 
    {
                ///
        /// <value>
        /// Type of the WorkRequest
        /// </value>
        ///
        public enum OperationTypeEnum {
            [EnumMember(Value = "CREATE_WAF_POLICY")]
            CreateWafPolicy,
            [EnumMember(Value = "UPDATE_WAF_POLICY")]
            UpdateWafPolicy,
            [EnumMember(Value = "DELETE_WAF_POLICY")]
            DeleteWafPolicy,
            [EnumMember(Value = "MOVE_WAF_POLICY")]
            MoveWafPolicy,
            [EnumMember(Value = "CREATE_NETWORK_ADDRESS_LIST")]
            CreateNetworkAddressList,
            [EnumMember(Value = "UPDATE_NETWORK_ADDRESS_LIST")]
            UpdateNetworkAddressList,
            [EnumMember(Value = "DELETE_NETWORK_ADDRESS_LIST")]
            DeleteNetworkAddressList,
            [EnumMember(Value = "MOVE_NETWORK_ADDRESS_LIST")]
            MoveNetworkAddressList,
            [EnumMember(Value = "CREATE_WEB_APP_FIREWALL")]
            CreateWebAppFirewall,
            [EnumMember(Value = "UPDATE_WEB_APP_FIREWALL")]
            UpdateWebAppFirewall,
            [EnumMember(Value = "DELETE_WEB_APP_FIREWALL")]
            DeleteWebAppFirewall,
            [EnumMember(Value = "MOVE_WEB_APP_FIREWALL")]
            MoveWebAppFirewall
        };

        /// <value>
        /// Type of the WorkRequest
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
                ///
        /// <value>
        /// Status of current work request.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// Status of current work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the WorkRequest.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that contains the WorkRequest.
        /// WorkRequests should be scoped to the same compartment as the resource the work request affects.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The resources affected by this WorkRequest.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Resources is required.")]
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
        /// <value>
        /// Percentage of the request completed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PercentComplete is required.")]
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <value>
        /// The date and time the request was created, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAccepted is required.")]
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The date and time the request was started, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the object was finished, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
    }
}
