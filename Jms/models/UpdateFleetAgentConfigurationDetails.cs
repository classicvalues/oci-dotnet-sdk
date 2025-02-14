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
    /// Attributes to update a Fleet Agent Configuration.
    /// </summary>
    public class UpdateFleetAgentConfigurationDetails 
    {
        
        /// <value>
        /// The frequency (in minutes) of JRE scanning. (That is, how often should JMS scan for JRE installations.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jreScanFrequencyInMinutes")]
        public System.Nullable<int> JreScanFrequencyInMinutes { get; set; }
        
        /// <value>
        /// The frequency (in minutes) of Java Usage Tracker processing. (That is, how often should JMS process data from the Java Usage Tracker.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "javaUsageTrackerProcessingFrequencyInMinutes")]
        public System.Nullable<int> JavaUsageTrackerProcessingFrequencyInMinutes { get; set; }
        
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public FleetAgentOsConfiguration LinuxConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public FleetAgentOsConfiguration WindowsConfiguration { get; set; }
        
    }
}
