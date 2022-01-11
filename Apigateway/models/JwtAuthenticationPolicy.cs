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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Validate a JWT token present in the header or query parameter. A valid
    /// policy must specify either tokenHeader or tokenQueryParam.
    /// 
    /// </summary>
    public class JwtAuthenticationPolicy : AuthenticationPolicy
    {
        
        /// <value>
        /// The name of the header containing the authentication token.
        /// </value>
        [JsonProperty(PropertyName = "tokenHeader")]
        public string TokenHeader { get; set; }
        
        /// <value>
        /// The name of the query parameter containing the authentication token.
        /// </value>
        [JsonProperty(PropertyName = "tokenQueryParam")]
        public string TokenQueryParam { get; set; }
        
        /// <value>
        /// The authentication scheme that is to be used when authenticating
        /// the token. This must to be provided if \"tokenHeader\" is specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tokenAuthScheme")]
        public string TokenAuthScheme { get; set; }
        
        /// <value>
        /// A list of parties that could have issued the token.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Issuers is required.")]
        [JsonProperty(PropertyName = "issuers")]
        public System.Collections.Generic.List<string> Issuers { get; set; }
        
        /// <value>
        /// The list of intended recipients for the token.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Audiences is required.")]
        [JsonProperty(PropertyName = "audiences")]
        public System.Collections.Generic.List<string> Audiences { get; set; }
        
        /// <value>
        /// A list of claims which should be validated to consider the token valid.
        /// </value>
        [JsonProperty(PropertyName = "verifyClaims")]
        public System.Collections.Generic.List<JsonWebTokenClaim> VerifyClaims { get; set; }
        
        /// <value>
        /// The maximum expected time difference between the system clocks
        /// of the token issuer and the API Gateway.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxClockSkewInSeconds")]
        public System.Nullable<float> MaxClockSkewInSeconds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicKeys is required.")]
        [JsonProperty(PropertyName = "publicKeys")]
        public PublicKeySet PublicKeys { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "JWT_AUTHENTICATION";
    }
}
