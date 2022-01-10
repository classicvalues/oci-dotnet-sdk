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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Used to validate the value set for a defined tag and contains the list of allowable `values`.
    /// <br/>
    /// You must specify at least one valid value in the `values` array. You can't have blank or
    /// or empty strings (`\"\"`). Duplicate values are not allowed.
    /// 
    /// </summary>
    public class EnumTagDefinitionValidator : BaseTagDefinitionValidator
    {
        
        /// <value>
        /// The list of allowed values for a definedTag value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.List<string> Values { get; set; }
        
        [JsonProperty(PropertyName = "validatorType")]
        private readonly string validatorType = "ENUM";
    }
}
