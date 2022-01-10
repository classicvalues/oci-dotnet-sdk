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


namespace Oci.WafService.Models
{
    /// <summary>
    /// An object that represents an action which returns a defined HTTP response.
    /// </summary>
    public class ReturnHttpResponseAction : Action
    {
        
        /// <value>
        /// Response code.
        /// <br/>
        /// The following response codes are valid values for this property:
        /// <br/>
        /// * 2xx
        /// <br/>
        ///   200 OK
        ///   201 Created
        ///   202 Accepted
        ///   206 Partial Content
        /// <br/>
        /// * 3xx
        /// <br/>
        ///   300 Multiple Choices
        ///   301 Moved Permanently
        ///   302 Found
        ///   303 See Other
        ///   307 Temporary Redirect
        /// <br/>
        /// * 4xx
        /// <br/>
        ///   400 Bad Request
        ///   401 Unauthorized
        ///   403 Forbidden
        ///   404 Not Found
        ///   405 Method Not Allowed
        ///   408 Request Timeout
        ///   409 Conflict
        ///   411 Length Required
        ///   412 Precondition Failed
        ///   413 Payload Too Large
        ///   414 URI Too Long
        ///   415 Unsupported Media Type
        ///   416 Range Not Satisfiable
        ///   422 Unprocessable Entity
        ///   494 Request Header Too Large
        ///   495 Cert Error
        ///   496 No Cert
        ///   497 HTTP to HTTPS
        /// <br/>
        /// * 5xx
        /// <br/>
        ///   500 Internal Server Error
        ///   501 Not Implemented
        ///   502 Bad Gateway
        ///   503 Service Unavailable
        ///   504 Gateway Timeout
        ///   507 Insufficient Storage
        /// <br/>
        /// Example: 200
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public System.Nullable<int> Code { get; set; }
        
        /// <value>
        /// Adds headers defined in this array for HTTP response.
        /// <br/>
        /// Hop-by-hop headers are not allowed to be set:
        /// <br/>
        /// * Connection
        /// * Keep-Alive
        /// * Proxy-Authenticate
        /// * Proxy-Authorization
        /// * TE
        /// * Trailer
        /// * Transfer-Encoding
        /// * Upgrade
        /// 
        /// </value>
        [JsonProperty(PropertyName = "headers")]
        public System.Collections.Generic.List<ResponseHeader> Headers { get; set; }
        
        [JsonProperty(PropertyName = "body")]
        public HttpResponseBody Body { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RETURN_HTTP_RESPONSE";
    }
}
