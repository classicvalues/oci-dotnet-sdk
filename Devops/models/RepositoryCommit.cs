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
    /// Commit object with commit information.
    /// </summary>
    public class RepositoryCommit 
    {
        
        /// <value>
        /// Commit hash pointed to by reference name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CommitId is required.")]
        [JsonProperty(PropertyName = "commitId")]
        public string CommitId { get; set; }
        
        /// <value>
        /// The commit message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CommitMessage is required.")]
        [JsonProperty(PropertyName = "commitMessage")]
        public string CommitMessage { get; set; }
        
        /// <value>
        /// Name of the author of the repository.
        /// </value>
        [JsonProperty(PropertyName = "authorName")]
        public string AuthorName { get; set; }
        
        /// <value>
        /// Email of the author of the repository.
        /// </value>
        [JsonProperty(PropertyName = "authorEmail")]
        public string AuthorEmail { get; set; }
        
        /// <value>
        /// Name of who creates the commit.
        /// </value>
        [JsonProperty(PropertyName = "committerName")]
        public string CommitterName { get; set; }
        
        /// <value>
        /// Email of who creates the commit.
        /// </value>
        [JsonProperty(PropertyName = "committerEmail")]
        public string CommitterEmail { get; set; }
        
        /// <value>
        /// An array of parent commit IDs of created commit.
        /// </value>
        [JsonProperty(PropertyName = "parentCommitIds")]
        public System.Collections.Generic.List<string> ParentCommitIds { get; set; }
        
        /// <value>
        /// The time at which commit was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Tree information for the specified commit.
        /// </value>
        [JsonProperty(PropertyName = "treeId")]
        public string TreeId { get; set; }
        
    }
}
