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
    /// The Database service supports the upgrade history of databases.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized, talk to an administrator. If you are an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about access control and compartments, see
    /// [Overview of the Identity Service](https://docs.cloud.oracle.com/Content/Identity/Concepts/overview.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class DatabaseUpgradeHistoryEntry 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database upgrade history.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The database upgrade action.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "UPGRADE")]
            Upgrade,
            [EnumMember(Value = "ROLLBACK")]
            Rollback
        };

        /// <value>
        /// The database upgrade action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
                ///
        /// <value>
        /// The source of the Oracle Database software to be used for the upgrade.
        ///  - Use `DB_HOME` to specify an existing Database Home to upgrade the database. The database is moved to the target Database Home and makes use of the Oracle Database software version of the target Database Home.
        ///  - Use `DB_VERSION` to specify a generally-available Oracle Database software version to upgrade the database.
        ///  - Use `DB_SOFTWARE_IMAGE` to specify a [database software image](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/databasesoftwareimage.htm) to upgrade the database.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            [EnumMember(Value = "DB_HOME")]
            DbHome,
            [EnumMember(Value = "DB_VERSION")]
            DbVersion,
            [EnumMember(Value = "DB_SOFTWARE_IMAGE")]
            DbSoftwareImage
        };

        /// <value>
        /// The source of the Oracle Database software to be used for the upgrade.
        ///  - Use `DB_HOME` to specify an existing Database Home to upgrade the database. The database is moved to the target Database Home and makes use of the Oracle Database software version of the target Database Home.
        ///  - Use `DB_VERSION` to specify a generally-available Oracle Database software version to upgrade the database.
        ///  - Use `DB_SOFTWARE_IMAGE` to specify a [database software image](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/databasesoftwareimage.htm) to upgrade the database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SourceEnum> Source { get; set; }
                ///
        /// <value>
        /// Status of database upgrade history SUCCEEDED|IN_PROGRESS|FAILED.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress
        };

        /// <value>
        /// Status of database upgrade history SUCCEEDED|IN_PROGRESS|FAILED.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// A valid Oracle Database version. To get a list of supported versions, use the {@link #listDbVersions(ListDbVersionsRequest) listDbVersions} operation.
        /// </value>
        [JsonProperty(PropertyName = "targetDBVersion")]
        public string TargetDBVersion { get; set; }
        
        /// <value>
        /// the database software image used for upgrading database.
        /// </value>
        [JsonProperty(PropertyName = "targetDatabaseSoftwareImageId")]
        public string TargetDatabaseSoftwareImageId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Home.
        /// </value>
        [JsonProperty(PropertyName = "targetDbHomeId")]
        public string TargetDbHomeId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Home.
        /// </value>
        [JsonProperty(PropertyName = "sourceDbHomeId")]
        public string SourceDbHomeId { get; set; }
        
        /// <value>
        /// The date and time when the database upgrade started.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time when the database upgrade ended.
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Additional upgrade options supported by DBUA(Database Upgrade Assistant).
        /// Example: &quot;-upgradeTimezone false -keepEvents&quot;
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public string Options { get; set; }
        
    }
}
