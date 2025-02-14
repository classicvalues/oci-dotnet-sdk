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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Details required to update a DB System.
    /// 
    /// </summary>
    public class UpdateDbSystemDetails 
    {
        
        /// <value>
        /// The user-friendly name for the DB System. It does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// User-provided data about the DB System.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the subnet the DB System is associated with.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// If the policy is to enable high availability of the instance, by
        /// maintaining secondary/failover capacity as necessary.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHighlyAvailable")]
        public System.Nullable<bool> IsHighlyAvailable { get; set; }
        
        /// <value>
        /// The availability domain on which to deploy the Read/Write endpoint. This defines the preferred primary instance.
        /// <br/>
        /// In a failover scenario, the Read/Write endpoint is redirected to one of the other availability domains
        /// and the MySQL instance in that domain is promoted to the primary instance.
        /// This redirection does not affect the IP address of the DB System in any way.
        /// <br/>
        /// For a standalone DB System, this defines the availability domain in which the DB System is placed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The fault domain on which to deploy the Read/Write endpoint. This defines the preferred primary instance.
        /// <br/>
        /// In a failover scenario, the Read/Write endpoint is redirected to one of the other fault domains
        /// and the MySQL instance in that domain is promoted to the primary instance.
        /// This redirection does not affect the IP address of the DB System in any way.
        /// <br/>
        /// For a standalone DB System, this defines the fault domain in which the DB System is placed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The shape of the DB System. The shape determines resources
        /// allocated to the DB System - CPU cores and memory for VM
        /// shapes; CPU cores, memory and storage for non-VM (or bare metal)
        /// shapes. To get a list of shapes, use the
        /// {@link #listShapes(ListShapesRequest) listShapes}
        /// operation.
        /// <br/>
        /// Changes in Shape will result in a downtime as the MySQL DB System is
        /// migrated to the new Compute instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The specific MySQL version identifier.
        /// </value>
        [JsonProperty(PropertyName = "mysqlVersion")]
        public string MysqlVersion { get; set; }
        
        /// <value>
        /// The OCID of the Configuration to be used for Instances in this DB System.
        /// </value>
        [JsonProperty(PropertyName = "configurationId")]
        public string ConfigurationId { get; set; }
        
        /// <value>
        /// The username for the administrative user for the MySQL Instance.
        /// </value>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }
        
        /// <value>
        /// The password for the administrative user. The password must be
        /// between 8 and 32 characters long, and must contain at least 1
        /// numeric character, 1 lowercase character, 1 uppercase character, and
        /// 1 special (nonalphanumeric) character.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }
        
        /// <value>
        /// New size of the data volume in GBs that will be created and attached.
        /// <br/>
        /// Increases in data storage size will happen asynchronously and will require DB System downtime.
        /// <br/>
        /// Decreases in data storage size are not supported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The hostname for the primary endpoint of the DB System. Used for DNS.
        /// The value is the hostname portion of the primary private IP's fully qualified domain name (FQDN)
        /// (for example, \"dbsystem-1\" in FQDN \"dbsystem-1.subnet123.vcn1.oraclevcn.com\").
        /// Must be unique across all VNICs in the subnet and comply with RFC 952 and RFC 1123.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// The IP address the DB System should be configured to listen on the provided subnet.
        /// It must be a free private IP address within the subnet's CIDR. If you don't specify a
        /// value, Oracle automatically assigns a private IP address from the subnet. This should
        /// be a \"dotted-quad\" style IPv4 address.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The port for primary endpoint of the DB System to listen on.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The TCP network port on which X Plugin listens for connections. This is the X Plugin equivalent of port.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "portX")]
        public System.Nullable<int> PortX { get; set; }
        
        [JsonProperty(PropertyName = "backupPolicy")]
        public UpdateBackupPolicyDetails BackupPolicy { get; set; }
        
        [JsonProperty(PropertyName = "maintenance")]
        public UpdateMaintenanceDetails Maintenance { get; set; }
        
        /// <value>
        /// Simple key-value pair applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
