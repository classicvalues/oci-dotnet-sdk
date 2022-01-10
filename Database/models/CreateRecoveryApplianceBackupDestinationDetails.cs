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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Used for creating Recovery Appliance backup destinations.
    /// </summary>
    public class CreateRecoveryApplianceBackupDestinationDetails : CreateBackupDestinationDetails
    {
        
        /// <value>
        /// The connection string for connecting to the Recovery Appliance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionString is required.")]
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The Virtual Private Catalog (VPC) users that are used to access the Recovery Appliance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VpcUsers is required.")]
        [JsonProperty(PropertyName = "vpcUsers")]
        public System.Collections.Generic.List<string> VpcUsers { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RECOVERY_APPLIANCE";
    }
}
