/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.SchService.Models
{
    /// <summary>
    /// The topic used for the Notifications target.
    /// 
    /// </summary>
    public class NotificationsTargetDetails : TargetDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the topic.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TopicId is required.")]
        [JsonProperty(PropertyName = "topicId")]
        public string TopicId { get; set; }
        
        /// <value>
        /// Whether to apply a simplified, user-friendly format to the message. Applies only when friendly formatting is supported by the service connector source and the subscription protocol.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "enableFormattedMessaging")]
        public System.Nullable<bool> EnableFormattedMessaging { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "notifications";
    }
}
