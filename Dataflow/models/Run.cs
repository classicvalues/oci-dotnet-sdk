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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// A run object.
    /// 
    /// </summary>
    public class Run 
    {
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of an archive.zip file containing custom dependencies that may be used to support the execution a Python, Java, or Scala application.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "archiveUri")]
        public string ArchiveUri { get; set; }
        
        /// <value>
        /// The arguments passed to the running application as command line arguments.  An argument is
        /// either a plain text or a placeholder. Placeholders are replaced using values from the parameters
        /// map.  Each placeholder specified must be represented in the parameters map else the request
        /// (POST or PUT) will fail with a HTTP 400 status code.  Placeholders are specified as
        /// `Service Api Spec`, where `name` is the name of the parameter.
        /// Example: [ &quot;--input&quot;, &quot;${input_file}&quot;, &quot;--name&quot;, &quot;John Doe&quot; ]If &quot;input_file&quot; has a value of &quot;mydata.xml&quot;, then the value above will be translated to--input mydata.xml --name &quot;John Doe&quot;
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<string> Arguments { get; set; }
        
        /// <value>
        /// The application ID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationId is required.")]
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The class for the application.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "className")]
        public string ClassName { get; set; }
        
        /// <value>
        /// The OCID of a compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The Spark configuration passed to the running process.
        /// See https://spark.apache.org/docs/latest/configuration.html#available-properties.
        /// Example: { &quot;spark.app.name&quot; : &quot;My App Name&quot;, &quot;spark.shuffle.io.maxRetries&quot; : &quot;4&quot; }Note: Not all Spark properties are permitted to be set.  Attempting to set a property that isnot allowed to be overwritten will cause a 400 status to be returned.
        /// </value>
        [JsonProperty(PropertyName = "configuration")]
        public System.Collections.Generic.Dictionary<string, string> Configuration { get; set; }
        
        /// <value>
        /// The data read by the run in bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataReadInBytes")]
        public System.Nullable<long> DataReadInBytes { get; set; }
        
        /// <value>
        /// The data written by the run in bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataWrittenInBytes")]
        public System.Nullable<long> DataWrittenInBytes { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. This name is not necessarily unique.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The VM shape for the driver. Sets the driver cores and memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DriverShape is required.")]
        [JsonProperty(PropertyName = "driverShape")]
        public string DriverShape { get; set; }
        
        /// <value>
        /// The input used for spark-submit command. For more details see https://spark.apache.org/docs/latest/submitting-applications.html#launching-applications-with-spark-submit.
        /// Supported options include ``--class``, ``--file``, ``--jars``, ``--conf``, ``--py-files``, and main application file with arguments.
        /// Example: --jars oci://path/to/a.jar,oci://path/to/b.jar --files oci://path/to/a.json,oci://path/to/b.csv --py-files oci://path/to/a.py,oci://path/to/b.py --conf spark.sql.crossJoin.enabled=true --class org.apache.spark.examples.SparkPi oci://path/to/main.jar 10Note: If execute is specified together with applicationId, className, configuration, fileUri, language, arguments, parameters during application create/update, or run create/submit,Data Flow service will use derived information from execute input only.
        /// </value>
        [JsonProperty(PropertyName = "execute")]
        public string Execute { get; set; }
        
        /// <value>
        /// The VM shape for the executors. Sets the executor cores and memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutorShape is required.")]
        [JsonProperty(PropertyName = "executorShape")]
        public string ExecutorShape { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the file containing the application to execute.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileUri is required.")]
        [JsonProperty(PropertyName = "fileUri")]
        public string FileUri { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The ID of a run.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The Spark language.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Language is required.")]
        [JsonProperty(PropertyName = "language")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ApplicationLanguage> Language { get; set; }
        
        /// <value>
        /// The detailed messages about the lifecycle state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The current state of this run.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RunLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the bucket where the Spark job logs are to be uploaded.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logsBucketUri")]
        public string LogsBucketUri { get; set; }
        
        /// <value>
        /// The OCID of OCI Hive Metastore.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metastoreId")]
        public string MetastoreId { get; set; }
        
        /// <value>
        /// The number of executor VMs requested.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumExecutors is required.")]
        [JsonProperty(PropertyName = "numExecutors")]
        public System.Nullable<int> NumExecutors { get; set; }
        
        /// <value>
        /// Unique Oracle assigned identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "opcRequestId")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The OCID of the user who created the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ownerPrincipalId")]
        public string OwnerPrincipalId { get; set; }
        
        /// <value>
        /// The username of the user who created the resource.  If the username of the owner does not exist,
        /// `null` will be returned and the caller should refer to the ownerPrincipalId value instead.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ownerUserName")]
        public string OwnerUserName { get; set; }
        
        /// <value>
        /// An array of name/value pairs used to fill placeholders found in properties like
        /// `Application.arguments`.  The name must be a string of one or more word characters
        /// (a-z, A-Z, 0-9, _).  The value can be a string of 0 or more characters of any kind.
        /// Example: [ { name: &quot;iterations&quot;, value: &quot;10&quot;}, { name: &quot;input_file&quot;, value: &quot;mydata.xml&quot; }, { name: &quot;variable_x&quot;, value: &quot;${x}&quot;} ]
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<ApplicationParameter> Parameters { get; set; }
        
        /// <value>
        /// An array of DNS zone names.
        /// Example: [ &quot;app.examplecorp.com&quot;, &quot;app.examplecorp2.com&quot; ]
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointDnsZones")]
        public System.Collections.Generic.List<string> PrivateEndpointDnsZones { get; set; }
        
        /// <value>
        /// The maximum number of hosts to be accessed through the private endpoint. This value is used
        /// to calculate the relevant CIDR block and should be a multiple of 256.  If the value is not a
        /// multiple of 256, it is rounded up to the next multiple of 256. For example, 300 is rounded up
        /// to 512.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointMaxHostCount")]
        public System.Nullable<int> PrivateEndpointMaxHostCount { get; set; }
        
        /// <value>
        /// An array of network security group OCIDs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointNsgIds")]
        public System.Collections.Generic.List<string> PrivateEndpointNsgIds { get; set; }
        
        /// <value>
        /// The OCID of a private endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointId")]
        public string PrivateEndpointId { get; set; }
        
        /// <value>
        /// The OCID of a subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointSubnetId")]
        public string PrivateEndpointSubnetId { get; set; }
        
        /// <value>
        /// The duration of the run in milliseconds.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "runDurationInMilliseconds")]
        public System.Nullable<long> RunDurationInMilliseconds { get; set; }
        
        /// <value>
        /// The Spark version utilized to run the application.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SparkVersion is required.")]
        [JsonProperty(PropertyName = "sparkVersion")]
        public string SparkVersion { get; set; }
        
        /// <value>
        /// The date and time a application was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2018-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time a application was updated, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2018-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The total number of oCPU requested by the run.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalOCpu")]
        public System.Nullable<int> TotalOCpu { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the bucket to be used as default warehouse directory
        /// for BATCH SQL runs.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "warehouseBucketUri")]
        public string WarehouseBucketUri { get; set; }
        
    }
}
