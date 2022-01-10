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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// Peer summary information for returning in a list.
    /// </summary>
    public class PeerSummary 
    {
        
        /// <value>
        /// Peer identifier
        /// </value>
        [JsonProperty(PropertyName = "peerKey")]
        public string PeerKey { get; set; }
        
        /// <value>
        /// The current state of the peer.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Peer.LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
