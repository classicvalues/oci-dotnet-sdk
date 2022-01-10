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
    /// The properties that define the network configuration for Kubernetes.
    /// </summary>
    public class KubernetesNetworkConfig 
    {
        
        /// <value>
        /// The CIDR block for Kubernetes pods.
        /// </value>
        [JsonProperty(PropertyName = "podsCidr")]
        public string PodsCidr { get; set; }
        
        /// <value>
        /// The CIDR block for Kubernetes services.
        /// </value>
        [JsonProperty(PropertyName = "servicesCidr")]
        public string ServicesCidr { get; set; }
        
    }
}
