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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Parameters detailing how to provision the source endpoint that is a MySQL Server.
    /// Typically a MySQL Server that is not managed by the MySQL Database Service.
    /// 
    /// </summary>
    public class CreateChannelSourceFromMysqlDetails : CreateChannelSourceDetails
    {
        
        /// <value>
        /// The network address of the MySQL instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The port the source MySQL instance listens on.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The name of the replication user on the source MySQL instance.
        /// The username has a maximum length of 96 characters. For more information,
        /// please see the [MySQL documentation](https://dev.mysql.com/doc/refman/8.0/en/change-master-to.html)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password for the replication user. The password must be
        /// between 8 and 32 characters long, and must contain at least 1
        /// numeric character, 1 lowercase character, 1 uppercase character,
        /// and 1 special (nonalphanumeric) character.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Password is required.")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The SSL mode of the Channel.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SslMode is required.")]
        [JsonProperty(PropertyName = "sslMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ChannelSourceMysql.SslModeEnum> SslMode { get; set; }
        
        [JsonProperty(PropertyName = "sslCaCertificate")]
        public CaCertificate SslCaCertificate { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "MYSQL";
    }
}
