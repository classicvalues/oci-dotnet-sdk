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
using Newtonsoft.Json.Linq;

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Base Metric Group for Host performance metrics
    /// 
    /// </summary>
    [JsonConverter(typeof(HostPerformanceMetricGroupModelConverter))]
    public class HostPerformanceMetricGroup 
    {
                ///
        /// <value>
        /// Name of the metric group
        /// 
        /// </value>
        ///
        public enum MetricNameEnum {
            [EnumMember(Value = "HOST_CPU_USAGE")]
            HostCpuUsage,
            [EnumMember(Value = "HOST_MEMORY_USAGE")]
            HostMemoryUsage,
            [EnumMember(Value = "HOST_NETWORK_ACTIVITY_SUMMARY")]
            HostNetworkActivitySummary
        };

        
        /// <value>
        /// Collection timestamp
        /// Example: &quot;2020-05-06T00:00:00.000Z&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCollected is required.")]
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
    }

    public class HostPerformanceMetricGroupModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(HostPerformanceMetricGroup);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(HostPerformanceMetricGroup);
            var discriminator = jsonObject["metricName"].Value<string>();
            switch (discriminator)
            {
                case "HOST_MEMORY_USAGE":
                    obj = new HostMemoryUsage();
                    break;
                case "HOST_CPU_USAGE":
                    obj = new HostCpuUsage();
                    break;
                case "HOST_NETWORK_ACTIVITY_SUMMARY":
                    obj = new HostNetworkActivitySummary();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
