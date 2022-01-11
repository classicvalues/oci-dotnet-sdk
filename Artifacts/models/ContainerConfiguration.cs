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


namespace Oci.ArtifactsService.Models
{
    /// <summary>
    /// Container configuration.
    /// </summary>
    public class ContainerConfiguration 
    {
        
        /// <value>
        /// Whether to create a new container repository when a container is pushed to a new repository path.
        /// Repositories created in this way belong to the root compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRepositoryCreatedOnFirstPush is required.")]
        [JsonProperty(PropertyName = "isRepositoryCreatedOnFirstPush")]
        public System.Nullable<bool> IsRepositoryCreatedOnFirstPush { get; set; }
        
        /// <value>
        /// The tenancy namespace used in the container repository path.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
    }
}
