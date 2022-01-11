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
    
    public class CreateExternalBackupJobDetails 
    {
        
        /// <value>
        /// The targeted availability domain for the backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment where this backup should be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name for the backup. This name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A valid Oracle Database version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The name of the database from which the backup is being taken.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The `DB_UNIQUE_NAME` of the Oracle Database being backed up.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The pluggable database name.
        /// </value>
        [JsonProperty(PropertyName = "pdbName")]
        public string PdbName { get; set; }
        
        /// <value>
        /// The `DBID` of the Oracle Database being backed up.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExternalDatabaseIdentifier is required.")]
        [JsonProperty(PropertyName = "externalDatabaseIdentifier")]
        public System.Nullable<long> ExternalDatabaseIdentifier { get; set; }
        
        /// <value>
        /// The character set for the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CharacterSet is required.")]
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }
        
        /// <value>
        /// The national character set for the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NcharacterSet is required.")]
        [JsonProperty(PropertyName = "ncharacterSet")]
        public string NcharacterSet { get; set; }
                ///
        /// <value>
        /// The mode (single instance or RAC) of the database being backed up.
        /// </value>
        ///
        public enum DatabaseModeEnum {
            [EnumMember(Value = "SI")]
            Si,
            [EnumMember(Value = "RAC")]
            Rac
        };

        /// <value>
        /// The mode (single instance or RAC) of the database being backed up.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseMode is required.")]
        [JsonProperty(PropertyName = "databaseMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseModeEnum> DatabaseMode { get; set; }
                ///
        /// <value>
        /// The Oracle Database edition to use for creating a database from this standalone backup.
        /// Note that 2-node RAC DB systems require Enterprise Edition - Extreme Performance.
        /// 
        /// </value>
        ///
        public enum DatabaseEditionEnum {
            [EnumMember(Value = "STANDARD_EDITION")]
            StandardEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION")]
            EnterpriseEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION_HIGH_PERFORMANCE")]
            EnterpriseEditionHighPerformance,
            [EnumMember(Value = "ENTERPRISE_EDITION_EXTREME_PERFORMANCE")]
            EnterpriseEditionExtremePerformance
        };

        /// <value>
        /// The Oracle Database edition to use for creating a database from this standalone backup.
        /// Note that 2-node RAC DB systems require Enterprise Edition - Extreme Performance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseEdition is required.")]
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseEditionEnum> DatabaseEdition { get; set; }
        
    }
}
