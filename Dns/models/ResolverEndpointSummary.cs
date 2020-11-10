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

namespace Oci.DnsService.Models
{
    /// <summary>
    /// An OCI DNS resolver endpoint.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(ResolverEndpointSummaryModelConverter))]
    public class ResolverEndpointSummary 
    {
        
        /// <value>
        /// The name of the resolver endpoint. Must be unique within the resolver.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The type of resolver endpoint. VNIC is currently the only supported type.
        /// 
        /// </value>
        ///
        public enum EndpointTypeEnum {
            [EnumMember(Value = "VNIC")]
            Vnic
        };

        
        /// <value>
        /// An IP address from which forwarded queries may be sent. For VNIC endpoints, this IP address must be part
        /// of the subnet and will be assigned by the system if unspecified when isForwarding is true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "forwardingAddress")]
        public string ForwardingAddress { get; set; }
        
        /// <value>
        /// A Boolean flag indicating whether or not the resolver endpoint is for forwarding.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsForwarding is required.")]
        [JsonProperty(PropertyName = "isForwarding")]
        public System.Nullable<bool> IsForwarding { get; set; }
        
        /// <value>
        /// A Boolean flag indicating whether or not the resolver endpoint is for listening.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsListening is required.")]
        [JsonProperty(PropertyName = "isListening")]
        public System.Nullable<bool> IsListening { get; set; }
        
        /// <value>
        /// An IP address to listen to queries on. For VNIC endpoints this IP address must be part of the
        /// subnet and will be assigned by the system if unspecified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "listeningAddress")]
        public string ListeningAddress { get; set; }
        
        /// <value>
        /// The OCID of the owning compartment. This will match the resolver that the resolver endpoint is under
        /// and will be updated if the resolver's compartment is changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The date and time the resource was created in \"YYYY-MM-ddThh:mm:ssZ\" format
        /// with a Z offset, as defined by RFC 3339.
        /// <br/>
        /// **Example: ** 2016-07-22T17:23:59:60Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the resource was last updated in \"YYYY-MM-ddThh:mm:ssZ\"
        /// format with a Z offset, as defined by RFC 3339.
        /// <br/>
        /// **Example: ** 2016-07-22T17:23:59:60Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the resource.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The canonical absolute URL of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Self is required.")]
        [JsonProperty(PropertyName = "self")]
        public string Self { get; set; }
        
    }

    public class ResolverEndpointSummaryModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ResolverEndpointSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ResolverEndpointSummary);
            var discriminator = jsonObject["endpointType"].Value<string>();
            switch (discriminator)
            {
                case "VNIC":
                    obj = new ResolverVnicEndpointSummary();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
