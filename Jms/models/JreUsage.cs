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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Java Runtime usage during a specified time period. A Java Runtime is identified by its vendor and version.
    /// </summary>
    public class JreUsage 
    {
        
        /// <value>
        /// The internal identifier of the Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the related fleet.  This property value is present only for /actions/listJreUsage.
        /// </value>
        [JsonProperty(PropertyName = "fleetId")]
        public string FleetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the related managed instance. This property value is present only for /actions/listJreUsage.
        /// </value>
        [JsonProperty(PropertyName = "managedInstanceId")]
        public string ManagedInstanceId { get; set; }
        
        /// <value>
        /// The security status of the Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "securityStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JreSecurityStatus> SecurityStatus { get; set; }
        
        /// <value>
        /// The release date of the Java Runtime (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        [JsonProperty(PropertyName = "releaseDate")]
        public System.Nullable<System.DateTime> ReleaseDate { get; set; }
        
        /// <value>
        /// The End of Support Life (EOSL) date of the Java Runtime (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        [JsonProperty(PropertyName = "endOfSupportLifeDate")]
        public System.Nullable<System.DateTime> EndOfSupportLifeDate { get; set; }
        
        /// <value>
        /// The vendor of the Java Runtime.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Vendor is required.")]
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }
        
        /// <value>
        /// The distribution of a Java Runtime is the name of the lineage of product to which it belongs, for example _Java(TM) SE Runtime Environment_.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Distribution is required.")]
        [JsonProperty(PropertyName = "distribution")]
        public string Distribution { get; set; }
        
        /// <value>
        /// The version of the Java Runtime.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The operating systems that have this Java Runtime installed.
        /// </value>
        [JsonProperty(PropertyName = "operatingSystems")]
        public System.Collections.Generic.List<OperatingSystem> OperatingSystems { get; set; }
        
        /// <value>
        /// The approximate count of installations that are installations of this Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "approximateInstallationCount")]
        public System.Nullable<int> ApproximateInstallationCount { get; set; }
        
        /// <value>
        /// The approximate count of the applications running on this Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "approximateApplicationCount")]
        public System.Nullable<int> ApproximateApplicationCount { get; set; }
        
        /// <value>
        /// The approximate count of the managed instances that report this Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "approximateManagedInstanceCount")]
        public System.Nullable<int> ApproximateManagedInstanceCount { get; set; }
        
        /// <value>
        /// Lower bound of the specified time period filter. JMS provides a view of the data that is _per day_. The query uses only the date element of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Upper bound of the specified time period filter. JMS provides a view of the data that is _per day_. The query uses only the date element of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The date and time the resource was _first_ reported to JMS.
        /// This is potentially _before_ the specified time period provided by the filters.
        /// For example, a resource can be first reported to JMS before the start of a specified time period,
        /// if it is also reported during the time period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSeen")]
        public System.Nullable<System.DateTime> TimeFirstSeen { get; set; }
        
        /// <value>
        /// The date and time the resource was _last_ reported to JMS.
        /// This is potentially _after_ the specified time period provided by the filters.
        /// For example, a resource can be last reported to JMS before the start of a specified time period,
        /// if it is also reported during the time period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastSeen")]
        public System.Nullable<System.DateTime> TimeLastSeen { get; set; }
        
    }
}
