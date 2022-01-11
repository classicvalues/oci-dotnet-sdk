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


namespace Oci.WafService.Models
{
    /// <summary>
    /// A NetworkAddressList that contains addresses.
    /// </summary>
    public class NetworkAddressListAddresses : NetworkAddressList
    {
        
        /// <value>
        /// A list of IP address prefixes in CIDR notation.
        /// To specify all addresses, use \"0.0.0.0/0\" for IPv4 and \"::/0\" for IPv6.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Addresses is required.")]
        [JsonProperty(PropertyName = "addresses")]
        public System.Collections.Generic.List<string> Addresses { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ADDRESSES";
    }
}
