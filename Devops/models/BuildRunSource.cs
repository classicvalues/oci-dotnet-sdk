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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The source from which the build run is triggered.
    /// </summary>
    [JsonConverter(typeof(BuildRunSourceModelConverter))]
    public class BuildRunSource 
    {
                ///
        /// <value>
        /// The source from which the build run is triggered.
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "GITHUB")]
            Github,
            [EnumMember(Value = "GITLAB")]
            Gitlab,
            [EnumMember(Value = "DEVOPS_CODE_REPOSITORY")]
            DevopsCodeRepository
        };

        
    }

    public class BuildRunSourceModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BuildRunSource);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BuildRunSource);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "GITHUB":
                    obj = new GithubBuildRunSource();
                    break;
                case "DEVOPS_CODE_REPOSITORY":
                    obj = new DevopsCodeRepositoryBuildRunSource();
                    break;
                case "MANUAL":
                    obj = new ManualBuildRunSource();
                    break;
                case "GITLAB":
                    obj = new GitlabBuildRunSource();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
