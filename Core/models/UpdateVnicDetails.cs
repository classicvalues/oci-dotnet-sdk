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


namespace Oci.CoreService.Models
{
    
    public class UpdateVnicDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The hostname for the VNIC's primary private IP. Used for DNS. The value is the hostname
        /// portion of the primary private IP's fully qualified domain name (FQDN)
        /// (for example, `bminstance-1` in FQDN `bminstance-1.subnet123.vcn1.oraclevcn.com`).
        /// Must be unique across all VNICs in the subnet and comply with
        /// [RFC 952](https://tools.ietf.org/html/rfc952) and
        /// [RFC 1123](https://tools.ietf.org/html/rfc1123).
        /// The value appears in the {@link Vnic} object and also the
        /// {@link PrivateIp} object returned by
        /// {@link #listPrivateIps(ListPrivateIpsRequest) listPrivateIps} and
        /// {@link #getPrivateIp(GetPrivateIpRequest) getPrivateIp}.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// A list of the OCIDs of the network security groups (NSGs) to add the VNIC to. Setting this as
        /// an empty array removes the VNIC from all network security groups.
        /// <br/>
        /// If the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution (instead of
        /// belonging to a subnet), the value of the `nsgIds` attribute is ignored. Instead, the
        /// VNIC belongs to the NSGs that are associated with the VLAN itself. See {@link Vlan}.
        /// <br/>
        /// For more information about NSGs, see
        /// {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// Whether the source/destination check is disabled on the VNIC.
        /// Defaults to `false`, which means the check is performed. For information about why you would
        /// skip the source/destination check, see
        /// [Using a Private IP as a Route Target](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingroutetables.htm#privateip).
        /// <br/>
        /// If the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution (instead of
        /// belonging to a subnet), the value of the `skipSourceDestCheck` attribute is ignored.
        /// This is because the source/destination check is always disabled for VNICs in a VLAN.
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "skipSourceDestCheck")]
        public System.Nullable<bool> SkipSourceDestCheck { get; set; }
        
    }
}
