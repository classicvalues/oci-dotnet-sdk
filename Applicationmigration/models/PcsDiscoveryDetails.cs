/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Credentials to access the Oracle Process Cloud Service application in the source environment. Application Migration connects to the
    /// application in the source environment with the supplied credentials.
    /// 
    /// </summary>
    public class PcsDiscoveryDetails : DiscoveryDetails
    {
        
        /// <value>
        /// Application administrator username to access the Oracle Process Cloud Service application in the source environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceInstanceUser is required.")]
        [JsonProperty(PropertyName = "serviceInstanceUser")]
        public string ServiceInstanceUser { get; set; }
        
        /// <value>
        /// Password for this user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceInstancePassword is required.")]
        [JsonProperty(PropertyName = "serviceInstancePassword")]
        public string ServiceInstancePassword { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "PCS";
    }
}
