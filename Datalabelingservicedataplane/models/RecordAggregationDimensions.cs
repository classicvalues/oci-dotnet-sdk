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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// Dimensions to summarize record information for a given dataset
    /// </summary>
    public class RecordAggregationDimensions 
    {
        
        /// <value>
        /// Whether the record has been labeled and has associated annotations.
        /// </value>
        [JsonProperty(PropertyName = "isLabeled")]
        public System.Nullable<bool> IsLabeled { get; set; }
        
        /// <value>
        /// Whether the annotation contains label.
        /// </value>
        [JsonProperty(PropertyName = "annotationLabelContains")]
        public string AnnotationLabelContains { get; set; }
        
    }
}
