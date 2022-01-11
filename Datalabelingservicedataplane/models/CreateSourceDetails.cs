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

namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// The source information is a polymorphic entity. It captures the details of how to access the data for record creation. The discriminator type must match the dataset's source type. The convention will be enforced by the API. It should only provide the difference in data necessary to access the content, i.e. the object storage path, or the database record id.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateSourceDetailsModelConverter))]
    public class CreateSourceDetails 
    {
                ///
        /// <value>
        /// The type of data source.
        /// OBJECT_STORAGE - source details for an object storage bucket.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "OBJECT_STORAGE")]
            ObjectStorage
        };

        
    }

    public class CreateSourceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateSourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateSourceDetails);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_STORAGE":
                    obj = new CreateObjectStorageSourceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
