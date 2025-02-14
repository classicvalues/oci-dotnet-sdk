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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Details about Oracle GoldenGate Microservices. If an empty object is specified, the stored Golden Gate details will be removed.
    /// 
    /// </summary>
    public class UpdateGoldenGateDetails 
    {
        
        [JsonProperty(PropertyName = "hub")]
        public UpdateGoldenGateHub Hub { get; set; }
        
        [JsonProperty(PropertyName = "settings")]
        public UpdateGoldenGateSettings Settings { get; set; }
        
    }
}
