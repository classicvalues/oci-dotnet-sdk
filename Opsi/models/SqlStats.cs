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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Sql Stats type object.
    /// </summary>
    public class SqlStats 
    {
        
        /// <value>
        /// Unique SQL_ID for a SQL Statement.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlIdentifier is required.")]
        [JsonProperty(PropertyName = "sqlIdentifier")]
        public string SqlIdentifier { get; set; }
        
        /// <value>
        /// Plan hash value for the SQL Execution Plan
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanHashValue is required.")]
        [JsonProperty(PropertyName = "planHashValue")]
        public System.Nullable<long> PlanHashValue { get; set; }
        
        /// <value>
        /// Collection timestamp
        /// Example: &quot;2020-03-31T00:00:00.000Z&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCollected is required.")]
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
        /// <value>
        /// Name of Database Instance
        /// Example: &quot;DB10902_1&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceName is required.")]
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// last_active_time
        /// Example: &quot;0000000099CCE300&quot;
        /// </value>
        [JsonProperty(PropertyName = "lastActiveTime")]
        public string LastActiveTime { get; set; }
        
        /// <value>
        /// Total integer of parse calls
        ///  Example: 60
        /// </value>
        [JsonProperty(PropertyName = "parseCalls")]
        public System.Nullable<long> ParseCalls { get; set; }
        
        /// <value>
        /// Number of disk reads
        /// </value>
        [JsonProperty(PropertyName = "diskReads")]
        public System.Nullable<long> DiskReads { get; set; }
        
        /// <value>
        /// Number of direct reads
        /// </value>
        [JsonProperty(PropertyName = "directReads")]
        public System.Nullable<long> DirectReads { get; set; }
        
        /// <value>
        /// Number of Direct writes
        /// </value>
        [JsonProperty(PropertyName = "directWrites")]
        public System.Nullable<long> DirectWrites { get; set; }
        
        /// <value>
        /// Number of Buffer Gets
        /// </value>
        [JsonProperty(PropertyName = "bufferGets")]
        public System.Nullable<long> BufferGets { get; set; }
        
        /// <value>
        /// Number of row processed
        /// </value>
        [JsonProperty(PropertyName = "rowsProcessed")]
        public System.Nullable<long> RowsProcessed { get; set; }
        
        /// <value>
        /// Number of serializable aborts
        /// </value>
        [JsonProperty(PropertyName = "serializableAborts")]
        public System.Nullable<long> SerializableAborts { get; set; }
        
        /// <value>
        /// Number of fetches
        /// </value>
        [JsonProperty(PropertyName = "fetches")]
        public System.Nullable<long> Fetches { get; set; }
        
        /// <value>
        /// Number of executions
        /// </value>
        [JsonProperty(PropertyName = "executions")]
        public System.Nullable<long> Executions { get; set; }
        
        /// <value>
        /// Number of executions attempted on this object, but prevented due to the SQL statement being in quarantine
        /// </value>
        [JsonProperty(PropertyName = "avoidedExecutions")]
        public System.Nullable<long> AvoidedExecutions { get; set; }
        
        /// <value>
        /// Number of times this cursor was fully executed since the cursor was brought into the library cache
        /// </value>
        [JsonProperty(PropertyName = "endOfFetchCount")]
        public System.Nullable<long> EndOfFetchCount { get; set; }
        
        /// <value>
        /// Number of times the object was either loaded or reloaded
        /// </value>
        [JsonProperty(PropertyName = "loads")]
        public System.Nullable<long> Loads { get; set; }
        
        /// <value>
        /// Number of cursors present in the cache with this SQL text and plan
        /// </value>
        [JsonProperty(PropertyName = "versionCount")]
        public System.Nullable<long> VersionCount { get; set; }
        
        /// <value>
        /// Number of times this child cursor has been invalidated
        /// </value>
        [JsonProperty(PropertyName = "invalidations")]
        public System.Nullable<long> Invalidations { get; set; }
        
        /// <value>
        /// Number of times that a parent cursor became obsolete
        /// </value>
        [JsonProperty(PropertyName = "obsoleteCount")]
        public System.Nullable<long> ObsoleteCount { get; set; }
        
        /// <value>
        /// Total number of executions performed by parallel execution servers (0 when the statement has never been executed in parallel)
        /// </value>
        [JsonProperty(PropertyName = "pxServersExecutions")]
        public System.Nullable<long> PxServersExecutions { get; set; }
        
        /// <value>
        /// CPU time (in microseconds) used by this cursor for parsing, executing, and fetching
        /// </value>
        [JsonProperty(PropertyName = "cpuTimeInUs")]
        public System.Nullable<long> CpuTimeInUs { get; set; }
        
        /// <value>
        /// Elapsed time (in microseconds) used by this cursor for parsing, executing, and fetching.
        /// </value>
        [JsonProperty(PropertyName = "elapsedTimeInUs")]
        public System.Nullable<long> ElapsedTimeInUs { get; set; }
        
        /// <value>
        /// Average hard parse time (in microseconds) used by this cursor
        /// </value>
        [JsonProperty(PropertyName = "avgHardParseTimeInUs")]
        public System.Nullable<long> AvgHardParseTimeInUs { get; set; }
        
        /// <value>
        /// Concurrency wait time (in microseconds)
        /// </value>
        [JsonProperty(PropertyName = "concurrencyWaitTimeInUs")]
        public System.Nullable<long> ConcurrencyWaitTimeInUs { get; set; }
        
        /// <value>
        /// Application wait time (in microseconds)
        /// </value>
        [JsonProperty(PropertyName = "applicationWaitTimeInUs")]
        public System.Nullable<long> ApplicationWaitTimeInUs { get; set; }
        
        /// <value>
        /// Cluster wait time (in microseconds). This value is specific to Oracle RAC
        /// </value>
        [JsonProperty(PropertyName = "clusterWaitTimeInUs")]
        public System.Nullable<long> ClusterWaitTimeInUs { get; set; }
        
        /// <value>
        /// User I/O wait time (in microseconds)
        /// </value>
        [JsonProperty(PropertyName = "userIoWaitTimeInUs")]
        public System.Nullable<long> UserIoWaitTimeInUs { get; set; }
        
        /// <value>
        /// PL/SQL execution time (in microseconds)
        /// </value>
        [JsonProperty(PropertyName = "plsqlExecTimeInUs")]
        public System.Nullable<long> PlsqlExecTimeInUs { get; set; }
        
        /// <value>
        /// Java execution time (in microseconds)
        /// </value>
        [JsonProperty(PropertyName = "javaExecTimeInUs")]
        public System.Nullable<long> JavaExecTimeInUs { get; set; }
        
        /// <value>
        /// Number of sorts that were done for the child cursor
        /// </value>
        [JsonProperty(PropertyName = "sorts")]
        public System.Nullable<long> Sorts { get; set; }
        
        /// <value>
        /// Total shared memory (in bytes) currently occupied by all cursors with this SQL text and plan
        /// </value>
        [JsonProperty(PropertyName = "sharableMem")]
        public System.Nullable<long> SharableMem { get; set; }
        
        /// <value>
        /// Total shared memory (in bytes) occupied by all cursors with this SQL text and plan if they were to be fully loaded in the shared pool (that is, cursor size)
        /// </value>
        [JsonProperty(PropertyName = "totalSharableMem")]
        public System.Nullable<long> TotalSharableMem { get; set; }
        
        /// <value>
        /// Typecheck memory
        /// </value>
        [JsonProperty(PropertyName = "typeCheckMem")]
        public System.Nullable<long> TypeCheckMem { get; set; }
        
        /// <value>
        /// Number of I/O bytes which can be filtered by the Exadata storage system
        /// </value>
        [JsonProperty(PropertyName = "ioCellOffloadEligibleBytes")]
        public System.Nullable<long> IoCellOffloadEligibleBytes { get; set; }
        
        /// <value>
        /// Number of I/O bytes exchanged between Oracle Database and the storage system. Typically used for Cache Fusion or parallel queries
        /// </value>
        [JsonProperty(PropertyName = "ioInterconnectBytes")]
        public System.Nullable<long> IoInterconnectBytes { get; set; }
        
        /// <value>
        /// Number of physical read I/O requests issued by the monitored SQL. The requests may not be disk reads
        /// </value>
        [JsonProperty(PropertyName = "physicalReadRequests")]
        public System.Nullable<long> PhysicalReadRequests { get; set; }
        
        /// <value>
        /// Number of bytes read from disks by the monitored SQL
        /// </value>
        [JsonProperty(PropertyName = "physicalReadBytes")]
        public System.Nullable<long> PhysicalReadBytes { get; set; }
        
        /// <value>
        /// Number of physical write I/O requests issued by the monitored SQL
        /// </value>
        [JsonProperty(PropertyName = "physicalWriteRequests")]
        public System.Nullable<long> PhysicalWriteRequests { get; set; }
        
        /// <value>
        /// Number of bytes written to disks by the monitored SQL
        /// </value>
        [JsonProperty(PropertyName = "physicalWriteBytes")]
        public System.Nullable<long> PhysicalWriteBytes { get; set; }
        
        /// <value>
        /// exact_matching_signature
        /// Example: &quot;18067345456756876713&quot;
        /// </value>
        [JsonProperty(PropertyName = "exactMatchingSignature")]
        public string ExactMatchingSignature { get; set; }
        
        /// <value>
        /// force_matching_signature
        /// Example: &quot;18067345456756876713&quot;
        /// </value>
        [JsonProperty(PropertyName = "forceMatchingSignature")]
        public string ForceMatchingSignature { get; set; }
        
        /// <value>
        /// Number of uncompressed bytes (that is, size after decompression) that are offloaded to the Exadata cells
        /// </value>
        [JsonProperty(PropertyName = "ioCellUncompressedBytes")]
        public System.Nullable<long> IoCellUncompressedBytes { get; set; }
        
        /// <value>
        /// Number of bytes that are returned by Exadata cell through the regular I/O path
        /// </value>
        [JsonProperty(PropertyName = "ioCellOffloadReturnedBytes")]
        public System.Nullable<long> IoCellOffloadReturnedBytes { get; set; }
        
        /// <value>
        /// Number of this child cursor
        /// </value>
        [JsonProperty(PropertyName = "childNumber")]
        public System.Nullable<long> ChildNumber { get; set; }
        
        /// <value>
        /// Oracle command type definition
        /// </value>
        [JsonProperty(PropertyName = "commandType")]
        public System.Nullable<long> CommandType { get; set; }
        
        /// <value>
        /// Number of users that have any of the child cursors open
        /// </value>
        [JsonProperty(PropertyName = "usersOpening")]
        public System.Nullable<long> UsersOpening { get; set; }
        
        /// <value>
        /// Number of users executing the statement
        /// </value>
        [JsonProperty(PropertyName = "usersExecuting")]
        public System.Nullable<long> UsersExecuting { get; set; }
        
        /// <value>
        /// Cost of this query given by the optimizer
        /// </value>
        [JsonProperty(PropertyName = "optimizerCost")]
        public System.Nullable<long> OptimizerCost { get; set; }
        
        /// <value>
        /// Total Number of rows in SQLStats table
        /// </value>
        [JsonProperty(PropertyName = "fullPlanHashValue")]
        public string FullPlanHashValue { get; set; }
        
        /// <value>
        /// Module name
        /// </value>
        [JsonProperty(PropertyName = "module")]
        public string Module { get; set; }
        
        /// <value>
        /// Service name
        /// </value>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }
        
        /// <value>
        /// Contains the name of the action that was executing when the SQL statement was first parsed, which is set by calling DBMS_APPLICATION_INFO.SET_ACTION
        /// </value>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
        
        /// <value>
        /// SQL profile used for this statement, if any
        /// </value>
        [JsonProperty(PropertyName = "sqlProfile")]
        public string SqlProfile { get; set; }
        
        /// <value>
        /// SQL patch used for this statement, if any
        /// </value>
        [JsonProperty(PropertyName = "sqlPatch")]
        public string SqlPatch { get; set; }
        
        /// <value>
        /// SQL plan baseline used for this statement, if any
        /// </value>
        [JsonProperty(PropertyName = "sqlPlanBaseline")]
        public string SqlPlanBaseline { get; set; }
        
        /// <value>
        /// Number of executions for the cursor since the last AWR snapshot
        /// </value>
        [JsonProperty(PropertyName = "deltaExecutionCount")]
        public System.Nullable<long> DeltaExecutionCount { get; set; }
        
        /// <value>
        /// CPU time (in microseconds) for the cursor since the last AWR snapshot
        /// </value>
        [JsonProperty(PropertyName = "deltaCpuTime")]
        public System.Nullable<long> DeltaCpuTime { get; set; }
        
        /// <value>
        /// Number of I/O bytes exchanged between the Oracle database and the storage system for the cursor since the last AWR snapshot
        /// </value>
        [JsonProperty(PropertyName = "deltaIoBytes")]
        public System.Nullable<long> DeltaIoBytes { get; set; }
        
        /// <value>
        /// Rank based on CPU Consumption
        /// </value>
        [JsonProperty(PropertyName = "deltaCpuRank")]
        public System.Nullable<long> DeltaCpuRank { get; set; }
        
        /// <value>
        /// Rank based on number of execution
        /// </value>
        [JsonProperty(PropertyName = "deltaExecsRank")]
        public System.Nullable<long> DeltaExecsRank { get; set; }
        
        /// <value>
        /// Rank based on sharable memory
        /// </value>
        [JsonProperty(PropertyName = "sharableMemRank")]
        public System.Nullable<long> SharableMemRank { get; set; }
        
        /// <value>
        /// Rank based on I/O Consumption
        /// </value>
        [JsonProperty(PropertyName = "deltaIoRank")]
        public System.Nullable<long> DeltaIoRank { get; set; }
        
        /// <value>
        /// Harmonic sum based on ranking parameters
        /// </value>
        [JsonProperty(PropertyName = "harmonicSum")]
        public System.Nullable<long> HarmonicSum { get; set; }
        
        /// <value>
        /// Weight based harmonic sum of ranking parameters 
        /// </value>
        [JsonProperty(PropertyName = "wtHarmonicSum")]
        public System.Nullable<long> WtHarmonicSum { get; set; }
        
        /// <value>
        /// Total number of rows in SQLStats table
        /// </value>
        [JsonProperty(PropertyName = "totalSqlCount")]
        public System.Nullable<long> TotalSqlCount { get; set; }
        
    }
}
