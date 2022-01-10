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
    /// Options for creating or updating node pools.
    /// </summary>
    public class NodePoolOptions 
    {
        
        /// <value>
        /// Available Kubernetes versions.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersions")]
        public System.Collections.Generic.List<string> KubernetesVersions { get; set; }
        
        /// <value>
        /// Available shapes for nodes.
        /// </value>
        [JsonProperty(PropertyName = "shapes")]
        public System.Collections.Generic.List<string> Shapes { get; set; }
        
        /// <value>
        /// Deprecated. See sources.
        /// When creating a node pool using the `CreateNodePoolDetails` object, only image names contained in this
        /// property can be passed to the `nodeImageName` property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "images")]
        public System.Collections.Generic.List<string> Images { get; set; }
        
        /// <value>
        /// Available source of the node.
        /// </value>
        [JsonProperty(PropertyName = "sources")]
        public System.Collections.Generic.List<NodeSourceOption> Sources { get; set; }
        
    }
}
