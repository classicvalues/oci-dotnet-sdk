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
    /// Properties used to update a published Oracle Cloud Infrastructure Data Flow object.
    /// </summary>
    public class UpdateExternalPublicationDetails 
    {
        
        /// <value>
        /// The unique OCID of the identifier that is returned after creating the Oracle Cloud Infrastructure Data Flow application.
        /// </value>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The OCID of the compartment where the application is created in the Oracle Cloud Infrastructure Data Flow Service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationCompartmentId is required.")]
        [JsonProperty(PropertyName = "applicationCompartmentId")]
        public string ApplicationCompartmentId { get; set; }
        
        /// <value>
        /// The name of the application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The details of the data flow or the application.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "resourceConfiguration")]
        public ResourceConfiguration ResourceConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "configurationDetails")]
        public ConfigurationDetails ConfigurationDetails { get; set; }
        
    }
}
