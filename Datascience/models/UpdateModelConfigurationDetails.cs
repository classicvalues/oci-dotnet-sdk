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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The model configuration details for update.
    /// </summary>
    public class UpdateModelConfigurationDetails 
    {
        
        /// <value>
        /// The OCID of the model you want to update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelId is required.")]
        [JsonProperty(PropertyName = "modelId")]
        public string ModelId { get; set; }
        
        [JsonProperty(PropertyName = "instanceConfiguration")]
        public InstanceConfiguration InstanceConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "scalingPolicy")]
        public ScalingPolicy ScalingPolicy { get; set; }
        
        /// <value>
        /// The network bandwidth for the model.
        /// </value>
        [JsonProperty(PropertyName = "bandwidthMbps")]
        public System.Nullable<int> BandwidthMbps { get; set; }
        
    }
}
