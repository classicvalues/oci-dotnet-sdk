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


namespace Oci.DatalabelingService.Models
{
    /// <summary>
    /// Allows outputting the latest records paired with annotations and write them to object storage.
    /// </summary>
    public class SnapshotDatasetDetails 
    {
        
        /// <value>
        /// Whether annotations are to be included in the export dataset digest.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AreAnnotationsIncluded is required.")]
        [JsonProperty(PropertyName = "areAnnotationsIncluded")]
        public System.Nullable<bool> AreAnnotationsIncluded { get; set; }
        
        /// <value>
        /// Whether to include records that have yet to be annotated in the export dataset digest.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AreUnannotatedRecordsIncluded is required.")]
        [JsonProperty(PropertyName = "areUnannotatedRecordsIncluded")]
        public System.Nullable<bool> AreUnannotatedRecordsIncluded { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportDetails is required.")]
        [JsonProperty(PropertyName = "exportDetails")]
        public ObjectStorageSnapshotExportDetails ExportDetails { get; set; }
        
    }
}
