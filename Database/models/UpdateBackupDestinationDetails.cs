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
    /// For a RECOVERY_APPLIANCE backup destination, used to update the connection string and/or the list of VPC users.
    /// For an NFS backup destination, there are 2 mount types - Self mount used for non-autonomous ExaCC and automated mount used for autonomous on ExaCC.
    /// 
    /// </summary>
    public class UpdateBackupDestinationDetails 
    {
        
        /// <value>
        /// For a RECOVERY_APPLIANCE backup destination, the Virtual Private Catalog (VPC) users that are used to access the Recovery Appliance.
        /// </value>
        [JsonProperty(PropertyName = "vpcUsers")]
        public System.Collections.Generic.List<string> VpcUsers { get; set; }
        
        /// <value>
        /// For a RECOVERY_APPLIANCE backup destination, the connection string for connecting to the Recovery Appliance.
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The local directory path on each VM cluster node where the NFS server location is mounted. The local directory path and the NFS server location must each be the same across all of the VM cluster nodes. Ensure that the NFS mount is maintained continuously on all of the VM cluster nodes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localMountPointPath")]
        public string LocalMountPointPath { get; set; }
                ///
        /// <value>
        /// NFS Mount type for backup destination.
        /// </value>
        ///
        public enum NfsMountTypeEnum {
            [EnumMember(Value = "SELF_MOUNT")]
            SelfMount,
            [EnumMember(Value = "AUTOMATED_MOUNT")]
            AutomatedMount
        };

        /// <value>
        /// NFS Mount type for backup destination.
        /// </value>
        [JsonProperty(PropertyName = "nfsMountType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NfsMountTypeEnum> NfsMountType { get; set; }
        
        /// <value>
        /// IP addresses for NFS Auto mount.
        /// </value>
        [JsonProperty(PropertyName = "nfsServer")]
        public System.Collections.Generic.List<string> NfsServer { get; set; }
        
        /// <value>
        /// Specifies the directory on which to mount the file system
        /// </value>
        [JsonProperty(PropertyName = "nfsServerExport")]
        public string NfsServerExport { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
