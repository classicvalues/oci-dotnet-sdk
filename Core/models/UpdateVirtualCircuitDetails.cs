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
    
    public class UpdateVirtualCircuitDetails 
    {
        
        /// <value>
        /// The provisioned data rate of the connection. To get a list of the
        /// available bandwidth levels (that is, shapes), see
        /// {@link #listFastConnectProviderVirtualCircuitBandwidthShapes(ListFastConnectProviderVirtualCircuitBandwidthShapesRequest) listFastConnectProviderVirtualCircuitBandwidthShapes}.
        /// To be updated only by the customer who owns the virtual circuit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bandwidthShapeName")]
        public string BandwidthShapeName { get; set; }
        
        /// <value>
        /// An array of mappings, each containing properties for a cross-connect or
        /// cross-connect group associated with this virtual circuit.
        /// <br/>
        /// The customer and provider can update different properties in the mapping
        /// depending on the situation. See the description of the
        /// {@link CrossConnectMapping}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crossConnectMappings")]
        public System.Collections.Generic.List<CrossConnectMapping> CrossConnectMappings { get; set; }
                ///
        ///
        public enum RoutingPolicyEnum {
            [EnumMember(Value = "ORACLE_SERVICE_NETWORK")]
            OracleServiceNetwork,
            [EnumMember(Value = "REGIONAL")]
            Regional,
            [EnumMember(Value = "MARKET_LEVEL")]
            MarketLevel,
            [EnumMember(Value = "GLOBAL")]
            Global
        };

        /// <value>
        /// The routing policy sets how routing information about the Oracle cloud is shared over a public virtual circuit.
        /// Policies available are: `ORACLE_SERVICE_NETWORK`, `REGIONAL`, `MARKET_LEVEL`, and `GLOBAL`.
        /// See [Route Filtering](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/routingonprem.htm#route_filtering) for details.
        /// By default, routing information is shared for all routes in the same market.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routingPolicy", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<RoutingPolicyEnum> RoutingPolicy { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `customerAsn`.
        /// If you specify values for both, the request will be rejected.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerBgpAsn")]
        public System.Nullable<int> CustomerBgpAsn { get; set; }
        
        /// <value>
        /// The BGP ASN of the network at the other end of the BGP
        /// session from Oracle.
        /// <br/>
        /// If the BGP session is from the customer's edge router to Oracle, the
        /// required value is the customer's ASN, and it can be updated only
        /// by the customer.
        /// <br/>
        /// If the BGP session is from the provider's edge router to Oracle, the
        /// required value is the provider's ASN, and it can be updated only
        /// by the provider.
        /// <br/>
        /// Can be a 2-byte or 4-byte ASN. Uses \"asplain\" format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerAsn")]
        public System.Nullable<long> CustomerAsn { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the {@link Drg}
        /// that this private virtual circuit uses.
        /// <br/>
        /// To be updated only by the customer who owns the virtual circuit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }
                ///
        /// <value>
        /// The provider's state in relation to this virtual circuit. Relevant only
        /// if the customer is using FastConnect via a provider. ACTIVE
        /// means the provider has provisioned the virtual circuit from their
        /// end. INACTIVE means the provider has not yet provisioned the virtual
        /// circuit, or has de-provisioned it.
        /// <br/>
        /// To be updated only by the provider.
        /// 
        /// </value>
        ///
        public enum ProviderStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The provider's state in relation to this virtual circuit. Relevant only
        /// if the customer is using FastConnect via a provider. ACTIVE
        /// means the provider has provisioned the virtual circuit from their
        /// end. INACTIVE means the provider has not yet provisioned the virtual
        /// circuit, or has de-provisioned it.
        /// <br/>
        /// To be updated only by the provider.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProviderStateEnum> ProviderState { get; set; }
        
        /// <value>
        /// The service key name offered by the provider (if the customer is connecting via a provider).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceKeyName")]
        public string ProviderServiceKeyName { get; set; }
        
        /// <value>
        /// Provider-supplied reference information about this virtual circuit.
        /// Relevant only if the customer is using FastConnect via a provider.
        /// <br/>
        /// To be updated only by the provider.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "referenceComment")]
        public string ReferenceComment { get; set; }
        
        /// <value>
        /// The layer 3 IP MTU to use on this virtual circuit.
        /// </value>
        [JsonProperty(PropertyName = "ipMtu")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VirtualCircuitIpMtu> IpMtu { get; set; }
        
    }
}
