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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// An `AuthToken` is an Oracle-generated token string that you can use to authenticate with third-party APIs
    /// that do not support Oracle Cloud Infrastructure's signature-based authentication. For example, use an `AuthToken`
    /// to authenticate with a Swift client with the Object Storage Service.
    /// <br/>
    /// The auth token is associated with the user's Console login. Auth tokens never expire. A user can have up to two
    /// auth tokens at a time.
    /// <br/>
    /// **Note:** The token is always an Oracle-generated string; you can't change it to a string of your choice.
    /// <br/>
    /// For more information, see [Managing User Credentials](https://docs.cloud.oracle.com/Content/Identity/Tasks/managingcredentials.htm).
    /// 
    /// </summary>
    public class AuthToken 
    {
        
        /// <value>
        /// The auth token. The value is available only in the response for `CreateAuthToken`, and not
        /// for `ListAuthTokens` or `UpdateAuthToken`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        
        /// <value>
        /// The OCID of the auth token.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the user the auth token belongs to.
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// The description you assign to the auth token. Does not have to be unique, and it's changeable.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Date and time the `AuthToken` object was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Date and time when this auth token will expire, in the format defined by RFC3339.
        /// Null if it never expires.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
                ///
        /// <value>
        /// The token's current state. After creating an auth token, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The token's current state. After creating an auth token, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The detailed status of INACTIVE lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "inactiveStatus")]
        public System.Nullable<long> InactiveStatus { get; set; }
        
    }
}
