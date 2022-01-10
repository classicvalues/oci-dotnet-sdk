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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies a linear rollout strategy for a compute instance group rolling deployment stage.
    /// </summary>
    public class ComputeInstanceGroupLinearRolloutPolicyByCount : ComputeInstanceGroupRolloutPolicy
    {
        
        /// <value>
        /// The number that will be used to determine how many instances will be deployed concurrently.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BatchCount is required.")]
        [JsonProperty(PropertyName = "batchCount")]
        public System.Nullable<int> BatchCount { get; set; }
        
        [JsonProperty(PropertyName = "policyType")]
        private readonly string policyType = "COMPUTE_INSTANCE_GROUP_LINEAR_ROLLOUT_POLICY_BY_COUNT";
    }
}
