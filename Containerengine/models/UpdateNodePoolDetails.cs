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
    /// The properties that define a request to update a node pool.
    /// </summary>
    public class UpdateNodePoolDetails 
    {
        
        /// <value>
        /// The new name for the cluster. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The version of Kubernetes to which the nodes in the node pool should be upgraded.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }
        
        /// <value>
        /// A list of key/value pairs to add to nodes after they join the Kubernetes cluster.
        /// </value>
        [JsonProperty(PropertyName = "initialNodeLabels")]
        public System.Collections.Generic.List<KeyValue> InitialNodeLabels { get; set; }
        
        /// <value>
        /// The number of nodes to have in each subnet specified in the subnetIds property. This property is deprecated,
        /// use nodeConfigDetails instead. If the current value of quantityPerSubnet is greater than 0, you can only
        /// use quantityPerSubnet to scale the node pool. If the current value of quantityPerSubnet is equal to 0 and
        /// the current value of size in nodeConfigDetails is greater than 0, before you can use quantityPerSubnet,
        /// you must first scale the node pool to 0 nodes using nodeConfigDetails.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quantityPerSubnet")]
        public System.Nullable<int> QuantityPerSubnet { get; set; }
        
        /// <value>
        /// The OCIDs of the subnets in which to place nodes for this node pool. This property is deprecated,
        /// use nodeConfigDetails instead. Only one of the subnetIds or nodeConfigDetails
        /// properties can be specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetIds")]
        public System.Collections.Generic.List<string> SubnetIds { get; set; }
        
        /// <value>
        /// The configuration of nodes in the node pool. Only one of the subnetIds or nodeConfigDetails
        /// properties should be specified. If the current value of quantityPerSubnet is greater than 0, the node
        /// pool may still be scaled using quantityPerSubnet. Before you can use nodeConfigDetails,
        /// you must first scale the node pool to 0 nodes using quantityPerSubnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeConfigDetails")]
        public UpdateNodePoolNodeConfigDetails NodeConfigDetails { get; set; }
        
        /// <value>
        /// A list of key/value pairs to add to each underlying OCI instance in the node pool on launch.
        /// </value>
        [JsonProperty(PropertyName = "nodeMetadata")]
        public System.Collections.Generic.Dictionary<string, string> NodeMetadata { get; set; }
        
        /// <value>
        /// Specify the source to use to launch nodes in the node pool. Currently, image is the only supported source.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeSourceDetails")]
        public NodeSourceDetails NodeSourceDetails { get; set; }
        
        /// <value>
        /// The SSH public key to add to each node in the node pool on launch.
        /// </value>
        [JsonProperty(PropertyName = "sshPublicKey")]
        public string SshPublicKey { get; set; }
        
        /// <value>
        /// The name of the node shape of the nodes in the node pool used on launch.
        /// </value>
        [JsonProperty(PropertyName = "nodeShape")]
        public string NodeShape { get; set; }
        
        /// <value>
        /// Specify the configuration of the shape to launch nodes in the node pool.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeShapeConfig")]
        public UpdateNodeShapeConfigDetails NodeShapeConfig { get; set; }
        
    }
}
