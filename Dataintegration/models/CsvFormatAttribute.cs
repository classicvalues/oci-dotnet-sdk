/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// The CSV format attribute.
    /// </summary>
    public class CsvFormatAttribute : AbstractFormatAttribute
    {
        
        /// <value>
        /// The encoding for the file.
        /// </value>
        [JsonProperty(PropertyName = "encoding")]
        public string Encoding { get; set; }

        /// <value>
        /// The escape character for the CSV format.
        /// </value>
        [JsonProperty(PropertyName = "escapeCharacter")]
        public string EscapeCharacter { get; set; }

        /// <value>
        /// The delimiter for the CSV format.
        /// </value>
        [JsonProperty(PropertyName = "delimiter")]
        public string Delimiter { get; set; }

        /// <value>
        /// The quote character for the CSV format.
        /// </value>
        [JsonProperty(PropertyName = "quoteCharacter")]
        public string QuoteCharacter { get; set; }

        /// <value>
        /// Defines whether the file has a header row.
        /// </value>
        [JsonProperty(PropertyName = "hasHeader")]
        public System.Nullable<bool> HasHeader { get; set; }

        /// <value>
        /// Defines whether a file pattern is supported.
        /// </value>
        [JsonProperty(PropertyName = "isFilePattern")]
        public System.Nullable<bool> IsFilePattern { get; set; }

        /// <value>
        /// Format for timestamp information.
        /// </value>
        [JsonProperty(PropertyName = "timestampFormat")]
        public string TimestampFormat { get; set; }
    }
}
