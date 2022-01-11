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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Entry for description of change on a file.
    /// </summary>
    public class DiffResponseEntry 
    {
        
        /// <value>
        /// Type of change made to file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChangeType is required.")]
        [JsonProperty(PropertyName = "changeType")]
        public string ChangeType { get; set; }
        
        /// <value>
        /// The type of the changed object.
        /// </value>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        /// <value>
        /// The ID of the commit where the change is coming from.
        /// </value>
        [JsonProperty(PropertyName = "commitId")]
        public string CommitId { get; set; }
        
        /// <value>
        /// The path on the target to the changed object.
        /// </value>
        [JsonProperty(PropertyName = "oldPath")]
        public string OldPath { get; set; }
        
        /// <value>
        /// The path on the source to the changed object.
        /// </value>
        [JsonProperty(PropertyName = "newPath")]
        public string NewPath { get; set; }
        
        /// <value>
        /// The ID of the changed object on the target.
        /// </value>
        [JsonProperty(PropertyName = "oldId")]
        public string OldId { get; set; }
        
        /// <value>
        /// The ID of the changed object on the source.
        /// </value>
        [JsonProperty(PropertyName = "newId")]
        public string NewId { get; set; }
        
        /// <value>
        /// The URL of the changed object.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// The number of lines added in whole difference.
        /// </value>
        [JsonProperty(PropertyName = "addedLinesCount")]
        public System.Nullable<int> AddedLinesCount { get; set; }
        
        /// <value>
        /// The number of lines deleted in whole difference.
        /// </value>
        [JsonProperty(PropertyName = "deletedLinesCount")]
        public System.Nullable<int> DeletedLinesCount { get; set; }
        
        /// <value>
        /// Indicates whether the changed file contains conflicts.
        /// </value>
        [JsonProperty(PropertyName = "areConflictsInFile")]
        public System.Nullable<bool> AreConflictsInFile { get; set; }
        
    }
}
