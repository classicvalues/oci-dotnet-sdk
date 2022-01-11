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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for a summary of an end user license agreement.
    /// </summary>
    public class AgreementSummary 
    {
        
        /// <value>
        /// The unique identifier for the agreement.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The content URL of the agreement.
        /// </value>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
                ///
        /// <value>
        /// Who authored the agreement.
        /// </value>
        ///
        public enum AuthorEnum {
            [EnumMember(Value = "ORACLE")]
            Oracle,
            [EnumMember(Value = "PARTNER")]
            Partner,
            [EnumMember(Value = "PII")]
            Pii
        };

        /// <value>
        /// Who authored the agreement.
        /// </value>
        [JsonProperty(PropertyName = "author")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuthorEnum> Author { get; set; }
        
        /// <value>
        /// Textual prompt to read and accept the agreement.
        /// </value>
        [JsonProperty(PropertyName = "prompt")]
        public string Prompt { get; set; }
        
    }
}
