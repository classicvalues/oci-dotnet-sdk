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


namespace Oci.EmailService.Models
{
    /// <summary>
    /// The full information representing an email suppression.
    /// </summary>
    public class Suppression 
    {
        
        /// <value>
        /// The OCID of the compartment to contain the suppression. Since
        /// suppressions are at the customer level, this must be the tenancy
        /// OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Email address of the suppression.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailAddress is required.")]
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }
        
        /// <value>
        /// The unique ID of the suppression.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The reason that the email address was suppressed. For more information on the types of bounces, see [Suppression List](https://docs.us-phoenix-1.oraclecloud.com/Content/Email/Concepts/overview.htm#components).
        /// </value>
        ///
        public enum ReasonEnum {
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            [EnumMember(Value = "HARDBOUNCE")]
            Hardbounce,
            [EnumMember(Value = "COMPLAINT")]
            Complaint,
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "SOFTBOUNCE")]
            Softbounce,
            [EnumMember(Value = "UNSUBSCRIBE")]
            Unsubscribe
        };

        /// <value>
        /// The reason that the email address was suppressed. For more information on the types of bounces, see [Suppression List](https://docs.us-phoenix-1.oraclecloud.com/Content/Email/Concepts/overview.htm#components).
        /// </value>
        [JsonProperty(PropertyName = "reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ReasonEnum> Reason { get; set; }
        
        /// <value>
        /// The date and time the suppression was added in \"YYYY-MM-ddThh:mmZ\"
        /// format with a Z offset, as defined by RFC 3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last date and time the suppression prevented submission
        /// in \"YYYY-MM-ddThh:mmZ\"
        /// format with a Z offset, as defined by RFC 3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastSuppressed")]
        public System.Nullable<System.DateTime> TimeLastSuppressed { get; set; }
        
        /// <value>
        /// The value of the Message-ID header from the email that triggered a suppression.
        /// This value is as defined in RFC 5322 section 3.6.4, excluding angle-brackets.
        /// Not provided for all types of suppressions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }
        
        /// <value>
        /// The specific error message returned by a system that resulted in the suppression.
        /// This message is usually an SMTP error code with additional descriptive text.
        /// Not provided for all types of suppressions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "errorDetail")]
        public string ErrorDetail { get; set; }
        
        /// <value>
        /// DNS name of the source of the error that caused the suppression.
        /// Will be set to either the remote-mta or reporting-mta field from a delivery status notification (RFC 3464) when available.
        /// Not provided for all types of suppressions, and not always known.
        /// <br/>
        /// Note: Most SMTP errors that cause suppressions come from software run by email receiving systems rather than from OCI email delivery itself.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "errorSource")]
        public string ErrorSource { get; set; }
        
    }
}
