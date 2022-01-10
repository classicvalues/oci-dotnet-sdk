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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// An update available for a managed instance
    /// </summary>
    public class AvailableUpdateSummary 
    {
        
        /// <value>
        /// Package name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Unique identifier for the package available for update. NOTE - This is not an OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The purpose of this update.
        /// </value>
        [JsonProperty(PropertyName = "updateType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateTypes> UpdateType { get; set; }
        
        /// <value>
        /// Type of the package
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Version of the installed package
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstalledVersion is required.")]
        [JsonProperty(PropertyName = "installedVersion")]
        public string InstalledVersion { get; set; }
        
        /// <value>
        /// Version of the package available for update
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailableVersion is required.")]
        [JsonProperty(PropertyName = "availableVersion")]
        public string AvailableVersion { get; set; }
        
        /// <value>
        /// The architecture for which this package was built
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }
        
        /// <value>
        /// List of errata containing this update
        /// </value>
        [JsonProperty(PropertyName = "errata")]
        public System.Collections.Generic.List<Id> Errata { get; set; }
        
        /// <value>
        /// List of CVEs applicable to this erratum
        /// </value>
        [JsonProperty(PropertyName = "relatedCves")]
        public System.Collections.Generic.List<string> RelatedCves { get; set; }
        
        /// <value>
        /// list of software sources that provide the software package
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceId> SoftwareSources { get; set; }
        
    }
}
