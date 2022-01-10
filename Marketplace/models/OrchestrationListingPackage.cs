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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// A listing package for orchestration.
    /// </summary>
    public class OrchestrationListingPackage : ListingPackage
    {
        
        /// <value>
        /// Link to the orchestration resource.
        /// </value>
        [JsonProperty(PropertyName = "resourceLink")]
        public string ResourceLink { get; set; }
        
        /// <value>
        /// List of variables for the orchestration resource.
        /// </value>
        [JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.List<OrchestrationVariable> Variables { get; set; }
        
        /// <value>
        /// The regions where you can deploy this listing package. (Some packages have restrictions that limit their deployment to United States regions only.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<Region> Regions { get; set; }
        
        [JsonProperty(PropertyName = "packageType")]
        private readonly string packageType = "ORCHESTRATION";
    }
}
