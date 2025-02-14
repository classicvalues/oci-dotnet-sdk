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

namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Value of a form field.
    /// </summary>
    [JsonConverter(typeof(FieldValueModelConverter))]
    public class FieldValue 
    {
                ///
        /// <value>
        /// Type of data detected.
        /// 
        /// </value>
        ///
        public enum ValueTypeEnum {
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "DATE")]
            Date,
            [EnumMember(Value = "TIME")]
            Time,
            [EnumMember(Value = "PHONE_NUMBER")]
            PhoneNumber,
            [EnumMember(Value = "NUMBER")]
            Number,
            [EnumMember(Value = "INTEGER")]
            Integer,
            [EnumMember(Value = "ARRAY")]
            Array
        };

        
        /// <value>
        /// Detected text of a field.
        /// </value>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// Confidence score between 0 to 1.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<float> Confidence { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BoundingPolygon is required.")]
        [JsonProperty(PropertyName = "boundingPolygon")]
        public BoundingPolygon BoundingPolygon { get; set; }
        
        /// <value>
        /// Indexes of the words in the field value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WordIndexes is required.")]
        [JsonProperty(PropertyName = "wordIndexes")]
        public System.Collections.Generic.List<int> WordIndexes { get; set; }
        
    }

    public class FieldValueModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(FieldValue);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(FieldValue);
            var discriminator = jsonObject["valueType"].Value<string>();
            switch (discriminator)
            {
                case "TIME":
                    obj = new ValueTime();
                    break;
                case "INTEGER":
                    obj = new ValueInteger();
                    break;
                case "DATE":
                    obj = new ValueDate();
                    break;
                case "NUMBER":
                    obj = new ValueNumber();
                    break;
                case "STRING":
                    obj = new ValueString();
                    break;
                case "PHONE_NUMBER":
                    obj = new ValuePhoneNumber();
                    break;
                case "ARRAY":
                    obj = new ValueArray();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
