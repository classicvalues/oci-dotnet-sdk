/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatacatalogService.Models
{
  /// <summary>
  /// Type of job as described below.
    /// HARVEST - Harvest jobs are metadata crawlers that extract schema from data assets.
    /// PROFILING - Profiling jobs are data profilers that extract metrics about data like histograms, distribution, min, max, avg and so on.
    /// SAMPLING - Sampling jobs extract a small subset of data for profiling and viewing.
    /// PREVIEW  - Preview jobs are metadata crawlers but allow users to filter and view metadata entities in data assets.
    /// IMPORT - Import jobs import metadata in data catalog repository from a data catalog exported file.
    /// EXPORT - Export jobs export data catalog metadata for imports into other data catalog repositories.
    /// IMPORT_GLOSSARY - Job type to import glossary metadata from a file.
    /// EXPORT_GLOSSARY - Job type to export glossary metadata to a file.
    /// ASYNC_DELETE - Job type for asynchronous bulk delete on data assets, folders and data entities.
    /// PURGE - Job type for cleaning up schedules, executions and logs of a Job.
    /// IMPORT_DATA_ASSET - Job type to import technical objects to a data asset.
    /// 
  /// </summary>
  public enum JobType {
      [EnumMember(Value = "HARVEST")]
      Harvest,
      [EnumMember(Value = "PROFILING")]
      Profiling,
      [EnumMember(Value = "SAMPLING")]
      Sampling,
      [EnumMember(Value = "PREVIEW")]
      Preview,
      [EnumMember(Value = "IMPORT")]
      Import,
      [EnumMember(Value = "EXPORT")]
      Export,
      [EnumMember(Value = "IMPORT_GLOSSARY")]
      ImportGlossary,
      [EnumMember(Value = "EXPORT_GLOSSARY")]
      ExportGlossary,
      [EnumMember(Value = "INTERNAL")]
      Internal,
      [EnumMember(Value = "PURGE")]
      Purge,
      [EnumMember(Value = "IMMEDIATE")]
      Immediate,
      [EnumMember(Value = "SCHEDULED")]
      Scheduled,
      [EnumMember(Value = "IMMEDIATE_EXECUTION")]
      ImmediateExecution,
      [EnumMember(Value = "SCHEDULED_EXECUTION")]
      ScheduledExecution,
      [EnumMember(Value = "SCHEDULED_EXECUTION_INSTANCE")]
      ScheduledExecutionInstance,
      [EnumMember(Value = "ASYNC_DELETE")]
      AsyncDelete,
      [EnumMember(Value = "IMPORT_DATA_ASSET")]
      ImportDataAsset
  }
}
