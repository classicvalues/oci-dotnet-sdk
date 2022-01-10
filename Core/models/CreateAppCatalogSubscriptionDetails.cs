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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// details for creating a subscription for a listing resource version.
    /// </summary>
    public class CreateAppCatalogSubscriptionDetails 
    {
        
        /// <value>
        /// The compartmentID for the subscription.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the listing.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingId is required.")]
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// Listing resource version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingResourceVersion is required.")]
        [JsonProperty(PropertyName = "listingResourceVersion")]
        public string ListingResourceVersion { get; set; }
        
        /// <value>
        /// Oracle TOU link
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OracleTermsOfUseLink is required.")]
        [JsonProperty(PropertyName = "oracleTermsOfUseLink")]
        public string OracleTermsOfUseLink { get; set; }
        
        /// <value>
        /// EULA link
        /// </value>
        [JsonProperty(PropertyName = "eulaLink")]
        public string EulaLink { get; set; }
        
        /// <value>
        /// Date and time the agreements were retrieved, in [RFC3339](https://tools.ietf.org/html/rfc3339) format.
        /// Example: 2018-03-20T12:32:53.532Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeRetrieved is required.")]
        [JsonProperty(PropertyName = "timeRetrieved")]
        public System.Nullable<System.DateTime> TimeRetrieved { get; set; }
        
        /// <value>
        /// A generated signature for this listing resource version retrieved the agreements API.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Signature is required.")]
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }
        
    }
}
