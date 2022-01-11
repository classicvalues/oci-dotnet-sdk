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
    /// The configuration for handling schema drift in a Source or Target operator.
    /// </summary>
    public class SchemaDriftConfig 
    {
                ///
        /// <value>
        /// The setting for how to handle extra columns/fields.  NULL_FILLUP means that nulls will be loaded into the target for extra columns.
        /// </value>
        ///
        public enum ExtraColumnHandlingEnum {
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "NULL_FILLUP")]
            NullFillup,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// The setting for how to handle extra columns/fields.  NULL_FILLUP means that nulls will be loaded into the target for extra columns.
        /// </value>
        [JsonProperty(PropertyName = "extraColumnHandling")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExtraColumnHandlingEnum> ExtraColumnHandling { get; set; }
                ///
        /// <value>
        /// The setting for how to handle missing columns/fields.  NULL_SELECT means that null values will be selected from the source for missing columns.
        /// </value>
        ///
        public enum MissingColumnHandlingEnum {
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "NULL_SELECT")]
            NullSelect,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// The setting for how to handle missing columns/fields.  NULL_SELECT means that null values will be selected from the source for missing columns.
        /// </value>
        [JsonProperty(PropertyName = "missingColumnHandling")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MissingColumnHandlingEnum> MissingColumnHandling { get; set; }
                ///
        /// <value>
        /// The setting for how to handle columns/fields with changed data types.
        /// </value>
        ///
        public enum DataTypeChangeHandlingEnum {
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "DO_CAST_IF_POSSIBLE")]
            DoCastIfPossible,
            [EnumMember(Value = "DO_NOT_ALLOW")]
            DoNotAllow
        };

        /// <value>
        /// The setting for how to handle columns/fields with changed data types.
        /// </value>
        [JsonProperty(PropertyName = "dataTypeChangeHandling")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataTypeChangeHandlingEnum> DataTypeChangeHandling { get; set; }
        
        /// <value>
        /// If true, display a validation warning for schema changes, even if they are allowed.
        /// </value>
        [JsonProperty(PropertyName = "isValidationWarningIfAllowed")]
        public System.Nullable<bool> IsValidationWarningIfAllowed { get; set; }
        
    }
}
