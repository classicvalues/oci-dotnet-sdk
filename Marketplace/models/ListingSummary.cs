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
    /// The model for a summary of an Oracle Cloud Infrastructure Marketplace listing.
    /// </summary>
    public class ListingSummary 
    {
        
        /// <value>
        /// The unique identifier for the listing in Marketplace.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the listing.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A short description of the listing.
        /// </value>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }
        
        /// <value>
        /// The tagline of the listing.
        /// </value>
        [JsonProperty(PropertyName = "tagline")]
        public string Tagline { get; set; }
        
        [JsonProperty(PropertyName = "icon")]
        public UploadData Icon { get; set; }
        
        /// <value>
        /// The listing's package type.
        /// </value>
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PackageTypeEnum> PackageType { get; set; }
                ///
        ///
        public enum PricingTypesEnum {
            [EnumMember(Value = "FREE")]
            Free,
            [EnumMember(Value = "BYOL")]
            Byol,
            [EnumMember(Value = "PAYGO")]
            Paygo
        };

        /// <value>
        /// Summary of the pricing types available across all packages in the listing.
        /// </value>
        [JsonProperty(PropertyName = "pricingTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<PricingTypesEnum> PricingTypes { get; set; }
        
        /// <value>
        /// The regions where you can deploy the listing. (Some listings have restrictions that limit their deployment to United States regions only.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<Region> Regions { get; set; }
        
        /// <value>
        /// Indicates whether the listing is featured.
        /// </value>
        [JsonProperty(PropertyName = "isFeatured")]
        public System.Nullable<bool> IsFeatured { get; set; }
        
        /// <value>
        /// Product categories that the listing belongs to.
        /// </value>
        [JsonProperty(PropertyName = "categories")]
        public System.Collections.Generic.List<string> Categories { get; set; }
        
        [JsonProperty(PropertyName = "publisher")]
        public PublisherSummary Publisher { get; set; }
        
        /// <value>
        /// The list of operating systems supported by the listing.
        /// </value>
        [JsonProperty(PropertyName = "supportedOperatingSystems")]
        public System.Collections.Generic.List<OperatingSystem> SupportedOperatingSystems { get; set; }
        
        /// <value>
        /// The publisher category to which the listing belongs. The publisher category informs where the listing appears for use.
        /// </value>
        [JsonProperty(PropertyName = "listingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ListingType> ListingType { get; set; }
        
    }
}
