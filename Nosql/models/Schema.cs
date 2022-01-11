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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// The table schema information as a JSON object.
    /// </summary>
    public class Schema 
    {
        
        /// <value>
        /// The columns of a table.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Columns is required.")]
        [JsonProperty(PropertyName = "columns")]
        public System.Collections.Generic.List<Column> Columns { get; set; }
        
        /// <value>
        /// A list of column names that make up a key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrimaryKey is required.")]
        [JsonProperty(PropertyName = "primaryKey")]
        public System.Collections.Generic.List<string> PrimaryKey { get; set; }
        
        /// <value>
        /// A list of column names that make up a key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShardKey is required.")]
        [JsonProperty(PropertyName = "shardKey")]
        public System.Collections.Generic.List<string> ShardKey { get; set; }
        
        /// <value>
        /// The default Time-to-Live for the table, in days.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ttl is required.")]
        [JsonProperty(PropertyName = "ttl")]
        public System.Nullable<int> Ttl { get; set; }
        
    }
}
