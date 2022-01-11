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

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Represents a data source in the Data Integration service.
    /// </summary>
    [JsonConverter(typeof(DataAssetModelConverter))]
    public class DataAsset 
    {
                ///
        /// <value>
        /// The type of the data asset.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "ORACLE_DATA_ASSET")]
            OracleDataAsset,
            [EnumMember(Value = "ORACLE_OBJECT_STORAGE_DATA_ASSET")]
            OracleObjectStorageDataAsset,
            [EnumMember(Value = "ORACLE_ATP_DATA_ASSET")]
            OracleAtpDataAsset,
            [EnumMember(Value = "ORACLE_ADWC_DATA_ASSET")]
            OracleAdwcDataAsset,
            [EnumMember(Value = "MYSQL_DATA_ASSET")]
            MysqlDataAsset,
            [EnumMember(Value = "GENERIC_JDBC_DATA_ASSET")]
            GenericJdbcDataAsset,
            [EnumMember(Value = "FUSION_APP_DATA_ASSET")]
            FusionAppDataAsset,
            [EnumMember(Value = "AMAZON_S3_DATA_ASSET")]
            AmazonS3DataAsset
        };

        
        /// <value>
        /// Generated key that can be used in API calls to identify data asset.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// User-defined description of the data asset.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The external key for the object.
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }
        
        /// <value>
        /// Additional properties for the data asset.
        /// </value>
        [JsonProperty(PropertyName = "assetProperties")]
        public System.Collections.Generic.Dictionary<string, string> AssetProperties { get; set; }
        
        [JsonProperty(PropertyName = "nativeTypeSystem")]
        public TypeSystem NativeTypeSystem { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
        /// <value>
        /// A key map. If provided, key is replaced with generated key. This structure provides mapping between user provided key and generated key.
        /// </value>
        [JsonProperty(PropertyName = "keyMap")]
        public System.Collections.Generic.Dictionary<string, string> KeyMap { get; set; }
        
    }

    public class DataAssetModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DataAsset);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DataAsset);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "GENERIC_JDBC_DATA_ASSET":
                    obj = new DataAssetFromJdbc();
                    break;
                case "ORACLE_DATA_ASSET":
                    obj = new DataAssetFromOracleDetails();
                    break;
                case "ORACLE_ADWC_DATA_ASSET":
                    obj = new DataAssetFromAdwcDetails();
                    break;
                case "AMAZON_S3_DATA_ASSET":
                    obj = new DataAssetFromAmazonS3();
                    break;
                case "ORACLE_OBJECT_STORAGE_DATA_ASSET":
                    obj = new DataAssetFromObjectStorageDetails();
                    break;
                case "FUSION_APP_DATA_ASSET":
                    obj = new DataAssetFromFusionApp();
                    break;
                case "ORACLE_ATP_DATA_ASSET":
                    obj = new DataAssetFromAtpDetails();
                    break;
                case "MYSQL_DATA_ASSET":
                    obj = new DataAssetFromMySQL();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
