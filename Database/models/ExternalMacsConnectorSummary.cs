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
    /// An Oracle Cloud Infrastructure resource that uses the [Management Agent cloud service (MACS)](https://docs.cloud.oracle.com/iaas/management-agents/index.html) to connect to an external Oracle Database.
    /// 
    /// </summary>
    public class ExternalMacsConnectorSummary : ExternalDatabaseConnectorSummary
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionString is required.")]
        [JsonProperty(PropertyName = "connectionString")]
        public DatabaseConnectionString ConnectionString { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionCredentials is required.")]
        [JsonProperty(PropertyName = "connectionCredentials")]
        public DatabaseConnectionCredentials ConnectionCredentials { get; set; }
        
        /// <value>
        /// The ID of the agent used for the
        /// {@link #createExternalDatabaseConnectorDetails(CreateExternalDatabaseConnectorDetailsRequest) createExternalDatabaseConnectorDetails}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectorAgentId is required.")]
        [JsonProperty(PropertyName = "connectorAgentId")]
        public string ConnectorAgentId { get; set; }
        
        [JsonProperty(PropertyName = "connectorType")]
        private readonly string connectorType = "MACS";
    }
}
