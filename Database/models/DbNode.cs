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
    
    public class DbNode 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbSystemId is required.")]
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VNIC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VnicId is required.")]
        [JsonProperty(PropertyName = "vnicId")]
        public string VnicId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup VNIC.
        /// </value>
        [JsonProperty(PropertyName = "backupVnicId")]
        public string BackupVnicId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the host IP address associated with the database node.
        /// <br/>
        /// **Note:** Applies only to Exadata Cloud Service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostIpId")]
        public string HostIpId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup IP address associated with the database node.
        /// <br/>
        /// **Note:** Applies only to Exadata Cloud Service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupIpId")]
        public string BackupIpId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the second VNIC.
        /// <br/>
        /// **Note:** Applies only to Exadata Cloud Service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vnic2Id")]
        public string Vnic2Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the second backup VNIC.
        /// <br/>
        /// **Note:** Applies only to Exadata Cloud Service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupVnic2Id")]
        public string BackupVnic2Id { get; set; }
                ///
        /// <value>
        /// The current state of the database node.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the database node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The host name for the database node.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The name of the Fault Domain the instance is contained in.
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The date and time that the database node was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The size (in GB) of the block storage volume allocation for the DB system. This attribute applies only for virtual machine DB systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "softwareStorageSizeInGB")]
        public System.Nullable<int> SoftwareStorageSizeInGB { get; set; }
                ///
        /// <value>
        /// The type of database node maintenance.
        /// </value>
        ///
        public enum MaintenanceTypeEnum {
            [EnumMember(Value = "VMDB_REBOOT_MIGRATION")]
            VmdbRebootMigration
        };

        /// <value>
        /// The type of database node maintenance.
        /// </value>
        [JsonProperty(PropertyName = "maintenanceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MaintenanceTypeEnum> MaintenanceType { get; set; }
        
        /// <value>
        /// Start date and time of maintenance window.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceWindowStart")]
        public System.Nullable<System.DateTime> TimeMaintenanceWindowStart { get; set; }
        
        /// <value>
        /// End date and time of maintenance window.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceWindowEnd")]
        public System.Nullable<System.DateTime> TimeMaintenanceWindowEnd { get; set; }
        
        /// <value>
        /// Additional information about the planned maintenance.
        /// </value>
        [JsonProperty(PropertyName = "additionalDetails")]
        public string AdditionalDetails { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled on the Db node.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The allocated memory in GBs on the Db node.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The allocated local node storage in GBs on the Db node.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exacc Db server associated with the database node.
        /// </value>
        [JsonProperty(PropertyName = "dbServerId")]
        public string DbServerId { get; set; }
        
    }
}
