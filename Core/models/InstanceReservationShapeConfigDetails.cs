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
    /// The shape configuration requested when launching instances in a compute capacity reservation.
    /// <br/>
    /// If the parameter is provided, the reservation is created with the resources that you specify. If some
    /// properties are missing or the parameter is not provided, the reservation is created
    /// with the default configuration values for the `shape` that you specify.
    /// <br/>
    /// Each shape only supports certain configurable values. If the values that you provide are not valid for the
    /// specified `shape`, an error is returned.
    /// <br/>
    /// For more information about customizing the resources that are allocated to flexible shapes,
    /// see [Flexible Shapes](https://docs.cloud.oracle.com/iaas/Content/Compute/References/computeshapes.htm#flexible).
    /// 
    /// </summary>
    public class InstanceReservationShapeConfigDetails 
    {
        
        /// <value>
        /// The total number of OCPUs available to the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// The total amount of memory available to the instance, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
        
    }
}
