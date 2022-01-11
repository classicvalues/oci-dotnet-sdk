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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about the Generic REST task. The endpoint and cancelEndpoint  properties are deprecated, use the properties executeRestCallConfig, cancelRestCallConfig and pollRestCallConfig for execute, cancel and polling of the calls.
    /// </summary>
    public class CreateTaskFromRestTask : CreateTaskDetails
    {
        
        [JsonProperty(PropertyName = "authDetails")]
        public AuthDetails AuthDetails { get; set; }
        
        [JsonProperty(PropertyName = "endpoint")]
        public Expression Endpoint { get; set; }
                ///
        /// <value>
        /// The REST method to use. This property is deprecated, use ExecuteRestCallConfig's methodType property instead.
        /// </value>
        ///
        public enum MethodTypeEnum {
            [EnumMember(Value = "GET")]
            Get,
            [EnumMember(Value = "POST")]
            Post,
            [EnumMember(Value = "PATCH")]
            Patch,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "PUT")]
            Put
        };

        /// <value>
        /// The REST method to use. This property is deprecated, use ExecuteRestCallConfig's methodType property instead.
        /// </value>
        [JsonProperty(PropertyName = "methodType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MethodTypeEnum> MethodType { get; set; }
        
        [JsonProperty(PropertyName = "headers")]
        public System.Object Headers { get; set; }
        
        /// <value>
        /// JSON data for payload body. This property is deprecated, use ExecuteRestCallConfig's payload config param instead.
        /// </value>
        [JsonProperty(PropertyName = "jsonData")]
        public string JsonData { get; set; }
                ///
        /// <value>
        /// The REST invocation pattern to use. ASYNC_OCI_WORKREQUEST is being deprecated as well as cancelEndpoint/MethodType.
        /// </value>
        ///
        public enum ApiCallModeEnum {
            [EnumMember(Value = "SYNCHRONOUS")]
            Synchronous,
            [EnumMember(Value = "ASYNC_OCI_WORKREQUEST")]
            AsyncOciWorkrequest,
            [EnumMember(Value = "ASYNC_GENERIC")]
            AsyncGeneric
        };

        /// <value>
        /// The REST invocation pattern to use. ASYNC_OCI_WORKREQUEST is being deprecated as well as cancelEndpoint/MethodType.
        /// </value>
        [JsonProperty(PropertyName = "apiCallMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ApiCallModeEnum> ApiCallMode { get; set; }
        
        [JsonProperty(PropertyName = "cancelEndpoint")]
        public Expression CancelEndpoint { get; set; }
                ///
        /// <value>
        /// The REST method to use for canceling the original request.
        /// </value>
        ///
        public enum CancelMethodTypeEnum {
            [EnumMember(Value = "GET")]
            Get,
            [EnumMember(Value = "POST")]
            Post,
            [EnumMember(Value = "PATCH")]
            Patch,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "PUT")]
            Put
        };

        /// <value>
        /// The REST method to use for canceling the original request.
        /// </value>
        [JsonProperty(PropertyName = "cancelMethodType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CancelMethodTypeEnum> CancelMethodType { get; set; }
        
        [JsonProperty(PropertyName = "executeRestCallConfig")]
        public ExecuteRestCallConfig ExecuteRestCallConfig { get; set; }
        
        [JsonProperty(PropertyName = "cancelRestCallConfig")]
        public CancelRestCallConfig CancelRestCallConfig { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "REST_TASK";
    }
}
