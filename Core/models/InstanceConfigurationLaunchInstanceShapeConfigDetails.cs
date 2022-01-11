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
    /// The shape configuration requested for the instance.
    /// <br/>
    /// If the parameter is provided, the instance is created
    /// with the resources that you specify. If some properties are missing or
    /// the entire parameter is not provided, the instance is created with the default
    /// configuration values for the `shape` that you specify.
    /// <br/>
    /// Each shape only supports certain configurable values. If the values that you provide are not valid for the
    /// specified `shape`, an error is returned.
    /// 
    /// </summary>
    public class InstanceConfigurationLaunchInstanceShapeConfigDetails 
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
                ///
        /// <value>
        /// The baseline OCPU utilization for a subcore burstable VM instance. Leave this attribute blank for a
        /// non-burstable instance, or explicitly specify non-burstable with `BASELINE_1_1`.
        /// <br/>
        /// The following values are supported:
        /// - `BASELINE_1_8` - baseline usage is 1/8 of an OCPU.
        /// - `BASELINE_1_2` - baseline usage is 1/2 of an OCPU.
        /// - `BASELINE_1_1` - baseline usage is an entire OCPU. This represents a non-burstable instance.
        /// 
        /// </value>
        ///
        public enum BaselineOcpuUtilizationEnum {
            [EnumMember(Value = "BASELINE_1_8")]
            Baseline18,
            [EnumMember(Value = "BASELINE_1_2")]
            Baseline12,
            [EnumMember(Value = "BASELINE_1_1")]
            Baseline11
        };

        /// <value>
        /// The baseline OCPU utilization for a subcore burstable VM instance. Leave this attribute blank for a
        /// non-burstable instance, or explicitly specify non-burstable with `BASELINE_1_1`.
        /// <br/>
        /// The following values are supported:
        /// - `BASELINE_1_8` - baseline usage is 1/8 of an OCPU.
        /// - `BASELINE_1_2` - baseline usage is 1/2 of an OCPU.
        /// - `BASELINE_1_1` - baseline usage is an entire OCPU. This represents a non-burstable instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "baselineOcpuUtilization")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BaselineOcpuUtilizationEnum> BaselineOcpuUtilization { get; set; }
        
    }
}
