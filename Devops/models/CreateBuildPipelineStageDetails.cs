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
    /// The information about a new stage.
    /// </summary>
    [JsonConverter(typeof(CreateBuildPipelineStageDetailsModelConverter))]
    public class CreateBuildPipelineStageDetails 
    {
        
        /// <value>
        /// Stage display name, which can be renamed and is not necessarily unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Optional description about the stage.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        
        /// <value>
        /// The OCID of the build pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BuildPipelineId is required.")]
        [JsonProperty(PropertyName = "buildPipelineId")]
        public string BuildPipelineId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BuildPipelineStagePredecessorCollection is required.")]
        [JsonProperty(PropertyName = "buildPipelineStagePredecessorCollection")]
        public BuildPipelineStagePredecessorCollection BuildPipelineStagePredecessorCollection { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class CreateBuildPipelineStageDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateBuildPipelineStageDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateBuildPipelineStageDetails);
            var discriminator = jsonObject["buildPipelineStageType"].Value<string>();
            switch (discriminator)
            {
                case "DELIVER_ARTIFACT":
                    obj = new CreateDeliverArtifactStageDetails();
                    break;
                case "TRIGGER_DEPLOYMENT_PIPELINE":
                    obj = new CreateTriggerDeploymentStageDetails();
                    break;
                case "WAIT":
                    obj = new CreateWaitStageDetails();
                    break;
                case "BUILD":
                    obj = new CreateBuildStageDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
