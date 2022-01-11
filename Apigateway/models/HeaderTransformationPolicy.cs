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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// A set of transformations to apply to HTTP headers that pass through the gateway.
    /// 
    /// </summary>
    public class HeaderTransformationPolicy 
    {
        
        [JsonProperty(PropertyName = "setHeaders")]
        public SetHeaderPolicy SetHeaders { get; set; }
        
        [JsonProperty(PropertyName = "renameHeaders")]
        public RenameHeaderPolicy RenameHeaders { get; set; }
        
        [JsonProperty(PropertyName = "filterHeaders")]
        public FilterHeaderPolicy FilterHeaders { get; set; }
        
    }
}
