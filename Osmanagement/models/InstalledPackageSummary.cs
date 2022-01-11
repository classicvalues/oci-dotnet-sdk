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
    /// A software package installed on a managed instance
    /// </summary>
    public class InstalledPackageSummary 
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
        /// Unique identifier for the package. NOTE - This is not an OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
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
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The architecture for which this package was built
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }
        
        /// <value>
        /// Install time of the package
        /// </value>
        [JsonProperty(PropertyName = "installTime")]
        public string InstallTime { get; set; }
        
        /// <value>
        /// date the package was issued by a providing erratum (if available)
        /// </value>
        [JsonProperty(PropertyName = "issued")]
        public string Issued { get; set; }
        
        /// <value>
        /// list of software sources that provide the software package
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceId> SoftwareSources { get; set; }
        
    }
}
