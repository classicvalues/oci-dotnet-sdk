/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The key object.
    /// </summary>
    [JsonConverter(typeof(KeyModelConverter))]
    public class Key 
    {
                ///
        /// <value>
        /// The key type.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "FOREIGN_KEY")]
            ForeignKey,
            [EnumMember(Value = "PRIMARY_KEY")]
            PrimaryKey,
            [EnumMember(Value = "UNIQUE_KEY")]
            UniqueKey
        };

        /// <value>
        /// The key type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelType is required.")]
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ModelTypeEnum> ModelType { get; set; }
    }

    public class KeyModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Key);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Key);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "UNIQUE_KEY":
                    obj = new UniqueKey();
                    break;
                case "FOREIGN_KEY":
                    obj = new ForeignKey();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
