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
    /// The Web Application Firewall configuration for the WAAS policy creation.
    /// </summary>
    public class WafConfigDetails 
    {
        
        /// <value>
        /// The access rules applied to the Web Application Firewall. Access rules allow custom content access policies to be defined and `ALLOW`, `DETECT`, or `BLOCK` actions to be taken on a request when specified criteria are met.
        /// </value>
        [JsonProperty(PropertyName = "accessRules")]
        public System.Collections.Generic.List<AccessRule> AccessRules { get; set; }
        
        /// <value>
        /// The settings used to limit the number of requests from an IP address.
        /// </value>
        [JsonProperty(PropertyName = "addressRateLimiting")]
        public AddressRateLimiting AddressRateLimiting { get; set; }
        
        /// <value>
        /// A list of CAPTCHA challenge settings. CAPTCHAs challenge requests to ensure a human is attempting to reach the specified URL and not a bot.
        /// </value>
        [JsonProperty(PropertyName = "captchas")]
        public System.Collections.Generic.List<Captcha> Captchas { get; set; }
        
        /// <value>
        /// The device fingerprint challenge settings. Blocks bots based on unique device fingerprint information.
        /// </value>
        [JsonProperty(PropertyName = "deviceFingerprintChallenge")]
        public DeviceFingerprintChallenge DeviceFingerprintChallenge { get; set; }
        
        /// <value>
        /// The human interaction challenge settings. Detects natural human interactions such as mouse movements, time on site, and page scrolling to identify bots.
        /// </value>
        [JsonProperty(PropertyName = "humanInteractionChallenge")]
        public HumanInteractionChallenge HumanInteractionChallenge { get; set; }
        
        /// <value>
        /// The JavaScript challenge settings. Blocks bots by challenging requests from browsers that have no JavaScript support.
        /// </value>
        [JsonProperty(PropertyName = "jsChallenge")]
        public JsChallenge JsChallenge { get; set; }
        
        /// <value>
        /// The key in the map of origins referencing the origin used for the Web Application Firewall. The origin must already be included in `Origins`. Required when creating the `WafConfig` resource, but is not required upon updating the configuration.
        /// </value>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }
        
        /// <value>
        /// A list of caching rules applied to the web application.
        /// </value>
        [JsonProperty(PropertyName = "cachingRules")]
        public System.Collections.Generic.List<CachingRule> CachingRules { get; set; }
        
        /// <value>
        /// A list of the custom protection rule OCIDs and their actions.
        /// </value>
        [JsonProperty(PropertyName = "customProtectionRules")]
        public System.Collections.Generic.List<CustomProtectionRuleSetting> CustomProtectionRules { get; set; }
        
        /// <value>
        /// The map of origin groups and their keys used to associate origins to the `wafConfig`. Origin groups allow you to apply weights to groups of origins for load balancing purposes. Origins with higher weights will receive larger proportions of client requests.
        /// To add additional origins to your WAAS policy, update the `origins` field of a `UpdateWaasPolicy` request.
        /// </value>
        [JsonProperty(PropertyName = "originGroups")]
        public System.Collections.Generic.List<string> OriginGroups { get; set; }
        
        /// <value>
        /// The settings applied to protection rules.
        /// </value>
        [JsonProperty(PropertyName = "protectionSettings")]
        public ProtectionSettings ProtectionSettings { get; set; }
        
        /// <value>
        /// A list of IP addresses that bypass the Web Application Firewall.
        /// </value>
        [JsonProperty(PropertyName = "whitelists")]
        public System.Collections.Generic.List<Whitelist> Whitelists { get; set; }
        
    }
}
