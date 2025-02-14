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
    /// <summary>
    /// The routes advertised to the Customer and the routes received from the Customer
    /// </summary>
    public class TunnelRouteSummary 
    {
        
        /// <value>
        /// BGP Network Layer Reachability Information
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// The age of the route
        /// </value>
        [JsonProperty(PropertyName = "age")]
        public System.Nullable<long> Age { get; set; }
        
        /// <value>
        /// Is this the best route
        /// </value>
        [JsonProperty(PropertyName = "isBestPath")]
        public System.Nullable<bool> IsBestPath { get; set; }
        
        /// <value>
        /// List of ASNs in AS Path
        /// </value>
        [JsonProperty(PropertyName = "asPath")]
        public System.Collections.Generic.List<int> AsPath { get; set; }
                ///
        /// <value>
        /// Route advertiser
        /// </value>
        ///
        public enum AdvertiserEnum {
            [EnumMember(Value = "CUSTOMER")]
            Customer,
            [EnumMember(Value = "ORACLE")]
            Oracle
        };

        /// <value>
        /// Route advertiser
        /// </value>
        [JsonProperty(PropertyName = "advertiser")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AdvertiserEnum> Advertiser { get; set; }
        
    }
}
