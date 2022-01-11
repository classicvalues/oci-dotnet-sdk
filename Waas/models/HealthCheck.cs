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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// Health checks monitor the status of your origin servers and only route traffic to the origins that pass the health check. If the health check fails, origin is automatically removed from the load balancing.
    /// There is roughly one health check per EDGE POP per period. Any checks that pass will be reported as \"healthy\".
    /// </summary>
    public class HealthCheck 
    {
        
        /// <value>
        /// Enables or disables the health checks.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
                ///
        /// <value>
        /// An HTTP verb (i.e. HEAD, GET, or POST) to use when performing the health check.
        /// </value>
        ///
        public enum MethodEnum {
            [EnumMember(Value = "GET")]
            Get,
            [EnumMember(Value = "HEAD")]
            Head,
            [EnumMember(Value = "POST")]
            Post
        };

        /// <value>
        /// An HTTP verb (i.e. HEAD, GET, or POST) to use when performing the health check.
        /// </value>
        [JsonProperty(PropertyName = "method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MethodEnum> Method { get; set; }
        
        /// <value>
        /// Path to visit on your origins when performing the health check.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// HTTP header fields to include in health check requests, expressed as `\"name\": \"value\"` properties. Because HTTP header field names are case-insensitive, any use of names that are case-insensitive equal to other names will be rejected. If Host is not specified, requests will include a Host header field with value matching the policy's protected domain. If User-Agent is not specified, requests will include a User-Agent header field with value \"waf health checks\".
        /// <br/>
        /// **Note:** The only currently-supported header fields are Host and User-Agent.
        /// </value>
        [JsonProperty(PropertyName = "headers")]
        public System.Collections.Generic.Dictionary<string, string> Headers { get; set; }
                ///
        ///
        public enum ExpectedResponseCodeGroupEnum {
            [EnumMember(Value = "2XX")]
            _2Xx,
            [EnumMember(Value = "3XX")]
            _3Xx,
            [EnumMember(Value = "4XX")]
            _4Xx,
            [EnumMember(Value = "5XX")]
            _5Xx
        };

        /// <value>
        /// The HTTP response codes that signify a healthy state.
        /// - **2XX:** Success response code group.
        /// - **3XX:** Redirection response code group.
        /// - **4XX:** Client errors response code group.
        /// - **5XX:** Server errors response code group.
        /// </value>
        [JsonProperty(PropertyName = "expectedResponseCodeGroup", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<ExpectedResponseCodeGroupEnum> ExpectedResponseCodeGroup { get; set; }
        
        /// <value>
        /// Enables or disables additional check for predefined text in addition to response code.
        /// </value>
        [JsonProperty(PropertyName = "isResponseTextCheckEnabled")]
        public System.Nullable<bool> IsResponseTextCheckEnabled { get; set; }
        
        /// <value>
        /// Health check will search for the given text in a case-sensitive manner within the response body and will fail if the text is not found.
        /// </value>
        [JsonProperty(PropertyName = "expectedResponseText")]
        public string ExpectedResponseText { get; set; }
        
        /// <value>
        /// Time between health checks of an individual origin server, in seconds.
        /// </value>
        [JsonProperty(PropertyName = "intervalInSeconds")]
        public System.Nullable<int> IntervalInSeconds { get; set; }
        
        /// <value>
        /// Response timeout represents wait time until request is considered failed, in seconds.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        /// <value>
        /// Number of successful health checks after which the server is marked up.
        /// </value>
        [JsonProperty(PropertyName = "healthyThreshold")]
        public System.Nullable<int> HealthyThreshold { get; set; }
        
        /// <value>
        /// Number of failed health checks after which the server is marked down.
        /// </value>
        [JsonProperty(PropertyName = "unhealthyThreshold")]
        public System.Nullable<int> UnhealthyThreshold { get; set; }
        
    }
}
