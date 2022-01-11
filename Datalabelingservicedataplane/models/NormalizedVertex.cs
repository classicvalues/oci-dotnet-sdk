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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// A NormalizedVertex is a cartesian coordinate that represents a corner between two segments of a polygon.
    /// </summary>
    public class NormalizedVertex 
    {
        
        /// <value>
        /// X axis coordinate
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "X is required.")]
        [JsonProperty(PropertyName = "x")]
        public System.Nullable<float> X { get; set; }
        
        /// <value>
        /// Y axis coordinate
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Y is required.")]
        [JsonProperty(PropertyName = "y")]
        public System.Nullable<float> Y { get; set; }
        
    }
}
