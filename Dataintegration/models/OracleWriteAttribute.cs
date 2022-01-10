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
    /// The Oracle write attribute.
    /// </summary>
    public class OracleWriteAttribute : AbstractWriteAttribute
    {
        
        /// <value>
        /// The batch size for writing.
        /// </value>
        [JsonProperty(PropertyName = "batchSize")]
        public System.Nullable<int> BatchSize { get; set; }
        
        /// <value>
        /// Specifies whether to truncate.
        /// </value>
        [JsonProperty(PropertyName = "isTruncate")]
        public System.Nullable<bool> IsTruncate { get; set; }
        
        /// <value>
        /// Specifies the isolation level.
        /// </value>
        [JsonProperty(PropertyName = "isolationLevel")]
        public string IsolationLevel { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLEWRITEATTRIBUTE";
    }
}
