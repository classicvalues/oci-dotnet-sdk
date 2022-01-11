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

namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Updates the property details for the configuration source.
    /// 
    /// </summary>
    [JsonConverter(typeof(UpdateConfigSourceDetailsModelConverter))]
    public class UpdateConfigSourceDetails 
    {
        
        
        /// <value>
        /// The path of the directory from which to run terraform. If not specified, the the root will be used. This parameter is ignored for the `configSourceType` value of `COMPARTMENT_CONFIG_SOURCE`.
        /// </value>
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory { get; set; }
        
    }

    public class UpdateConfigSourceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateConfigSourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateConfigSourceDetails);
            var discriminator = jsonObject["configSourceType"].Value<string>();
            switch (discriminator)
            {
                case "GIT_CONFIG_SOURCE":
                    obj = new UpdateGitConfigSourceDetails();
                    break;
                case "OBJECT_STORAGE_CONFIG_SOURCE":
                    obj = new UpdateObjectStorageConfigSourceDetails();
                    break;
                case "ZIP_UPLOAD":
                    obj = new UpdateZipUploadConfigSourceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
