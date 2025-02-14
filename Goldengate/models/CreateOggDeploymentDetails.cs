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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Deployment Data for creating an OggDeployment
    /// 
    /// </summary>
    public class CreateOggDeploymentDetails 
    {
        
        /// <value>
        /// The name given to the GoldenGate service deployment. The name must be 1 to 32 characters long, must contain only alphanumeric characters and must start with a letter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentName is required.")]
        [JsonProperty(PropertyName = "deploymentName")]
        public string DeploymentName { get; set; }
        
        /// <value>
        /// The GoldenGate deployment console username.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminUsername is required.")]
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }
        
        /// <value>
        /// The password associated with the GoldenGate deployment console username. The password must be 8 to 30 characters long and must contain at least 1 uppercase, 1 lowercase, 1 numeric, and 1 special character. Special characters such as \u2018$\u2019, \u2018^\u2019, or \u2018?\u2019 are not allowed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminPassword is required.")]
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }
        
        /// <value>
        /// A PEM-encoded SSL certificate.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }
        
        /// <value>
        /// A PEM-encoded private key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
    }
}
