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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Simple Condition object.
    /// </summary>
    public class SimpleCondition : Condition
    {
        
        /// <value>
        /// parameter Key
        /// </value>
        [JsonProperty(PropertyName = "parameter")]
        public string Parameter { get; set; }
        
        /// <value>
        /// type of operator
        /// </value>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperatorType> Operator { get; set; }
        
        /// <value>
        /// type of operator
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// type of value
        /// </value>
        [JsonProperty(PropertyName = "valueType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ConditionValueType> ValueType { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "SIMPLE";
    }
}
