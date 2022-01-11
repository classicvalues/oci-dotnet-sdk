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
    /// Supported configuration metric groups for database capacity planning service.
    /// 
    /// </summary>
    [JsonConverter(typeof(DatabaseConfigurationMetricGroupModelConverter))]
    public class DatabaseConfigurationMetricGroup 
    {
                ///
        /// <value>
        /// Name of the metric group.
        /// 
        /// </value>
        ///
        public enum MetricNameEnum {
            [EnumMember(Value = "DB_EXTERNAL_PROPERTIES")]
            DbExternalProperties,
            [EnumMember(Value = "DB_EXTERNAL_INSTANCE")]
            DbExternalInstance,
            [EnumMember(Value = "DB_OS_CONFIG_INSTANCE")]
            DbOsConfigInstance
        };

        
        /// <value>
        /// Collection timestamp
        /// Example: &quot;2020-05-06T00:00:00.000Z&quot;
        /// </value>
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
    }

    public class DatabaseConfigurationMetricGroupModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DatabaseConfigurationMetricGroup);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DatabaseConfigurationMetricGroup);
            var discriminator = jsonObject["metricName"].Value<string>();
            switch (discriminator)
            {
                case "DB_OS_CONFIG_INSTANCE":
                    obj = new DBOSConfigInstance();
                    break;
                case "DB_EXTERNAL_INSTANCE":
                    obj = new DBExternalInstance();
                    break;
                case "DB_EXTERNAL_PROPERTIES":
                    obj = new DBExternalProperties();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
