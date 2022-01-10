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
    
    public class CreateVirtualCircuitDetails 
    {
        
        /// <value>
        /// The provisioned data rate of the connection. To get a list of the
        /// available bandwidth levels (that is, shapes), see
        /// {@link #listFastConnectProviderVirtualCircuitBandwidthShapes(ListFastConnectProviderVirtualCircuitBandwidthShapesRequest) listFastConnectProviderVirtualCircuitBandwidthShapes}.
        /// <br/>
        /// Example: 10 Gbps
        /// </value>
        [JsonProperty(PropertyName = "bandwidthShapeName")]
        public string BandwidthShapeName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to contain the virtual circuit.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Create a `CrossConnectMapping` for each cross-connect or cross-connect
        /// group this virtual circuit will run on.
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
        /// Your BGP ASN (either public or private). Provide this value only if
        /// there's a BGP session that goes from your edge router to Oracle.
        /// Otherwise, leave this empty or null.
        /// Can be a 2-byte or 4-byte ASN. Uses \"asplain\" format.
        /// <br/>
        /// Example: 12345 (2-byte) or 1587232876 (4-byte)
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
        /// For private virtual circuits only. The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the {@link Drg}
        /// that this virtual circuit uses.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `providerServiceId`.
        /// To get a list of the provider names, see
        /// {@link #listFastConnectProviderServices(ListFastConnectProviderServicesRequest) listFastConnectProviderServices}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the service offered by the provider (if you're connecting
        /// via a provider). To get a list of the available service offerings, see
        /// {@link #listFastConnectProviderServices(ListFastConnectProviderServicesRequest) listFastConnectProviderServices}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceId")]
        public string ProviderServiceId { get; set; }
        
        /// <value>
        /// The service key name offered by the provider (if the customer is connecting via a provider).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceKeyName")]
        public string ProviderServiceKeyName { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `providerServiceId`.
        /// To get a list of the provider names, see
        /// {@link #listFastConnectProviderServices(ListFastConnectProviderServicesRequest) listFastConnectProviderServices}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "providerServiceName")]
        public string ProviderServiceName { get; set; }
        
        /// <value>
        /// For a public virtual circuit. The public IP prefixes (CIDRs) the customer wants to
        /// advertise across the connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicPrefixes")]
        public System.Collections.Generic.List<CreateVirtualCircuitPublicPrefixDetails> PublicPrefixes { get; set; }
        
        /// <value>
        /// The Oracle Cloud Infrastructure region where this virtual
        /// circuit is located.
        /// Example: phx
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
                ///
        /// <value>
        /// The type of IP addresses used in this virtual circuit. PRIVATE
        /// means [RFC 1918](https://tools.ietf.org/html/rfc1918) addresses
        /// (10.0.0.0/8, 172.16/12, and 192.168/16).
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "PUBLIC")]
            Public,
            [EnumMember(Value = "PRIVATE")]
            Private
        };

        /// <value>
        /// The type of IP addresses used in this virtual circuit. PRIVATE
        /// means [RFC 1918](https://tools.ietf.org/html/rfc1918) addresses
        /// (10.0.0.0/8, 172.16/12, and 192.168/16).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The layer 3 IP MTU to use with this virtual circuit.
        /// </value>
        [JsonProperty(PropertyName = "ipMtu")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VirtualCircuitIpMtu> IpMtu { get; set; }
        
    }
}
