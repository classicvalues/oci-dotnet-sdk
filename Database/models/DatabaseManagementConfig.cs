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
    /// The configuration of the Database Management service.
    /// </summary>
    public class DatabaseManagementConfig 
    {
                ///
        /// <value>
        /// The status of the Database Management service.
        /// </value>
        ///
        public enum DatabaseManagementStatusEnum {
            [EnumMember(Value = "ENABLING")]
            Enabling,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLING")]
            Disabling,
            [EnumMember(Value = "NOT_ENABLED")]
            NotEnabled,
            [EnumMember(Value = "FAILED_ENABLING")]
            FailedEnabling,
            [EnumMember(Value = "FAILED_DISABLING")]
            FailedDisabling
        };

        /// <value>
        /// The status of the Database Management service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseManagementStatus is required.")]
        [JsonProperty(PropertyName = "databaseManagementStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseManagementStatusEnum> DatabaseManagementStatus { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the
        /// {@link #createExternalDatabaseConnectorDetails(CreateExternalDatabaseConnectorDetailsRequest) createExternalDatabaseConnectorDetails}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseManagementConnectionId")]
        public string DatabaseManagementConnectionId { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the external database.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the external database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
    }
}
