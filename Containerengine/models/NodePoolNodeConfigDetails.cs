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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The size and placement configuration of nodes in the node pool.
    /// </summary>
    public class NodePoolNodeConfigDetails 
    {
        
        /// <value>
        /// The number of nodes in the node pool.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<int> Size { get; set; }
        
        /// <value>
        /// The OCIDs of the Network Security Group(s) to associate nodes for this node pool with. For more information about NSGs, see {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The placement configurations for the node pool. Provide one placement
        /// configuration for each availability domain in which you intend to launch a node.
        /// <br/>
        /// To use the node pool with a regional subnet, provide a placement configuration for
        /// each availability domain, and include the regional subnet in each placement
        /// configuration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "placementConfigs")]
        public System.Collections.Generic.List<NodePoolPlacementConfigDetails> PlacementConfigs { get; set; }
        
    }
}
