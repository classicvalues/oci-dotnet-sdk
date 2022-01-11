/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemanagementService.Models
{
  /// <summary>
  /// The type of Oracle Database installation:
    /// - EXTERNAL_SIDB: Single instance external database.
    /// - EXTERNAL_RAC: Oracle Real Application Clusters (Oracle RAC) external database.
    /// - CLOUD_SIDB: Single instance database in Oracle Cloud.
    /// - CLOUD_RAC: Oracle RAC database in Oracle Cloud.
    /// - SHARED: Autonomous shared database in Oracle Cloud.
    /// - DEDICATED: Autonomous dedicated database in Oracle Cloud.
    /// 
  /// </summary>
  public enum DatabaseType {
      [EnumMember(Value = "EXTERNAL_SIDB")]
      ExternalSidb,
      [EnumMember(Value = "EXTERNAL_RAC")]
      ExternalRac,
      [EnumMember(Value = "CLOUD_SIDB")]
      CloudSidb,
      [EnumMember(Value = "CLOUD_RAC")]
      CloudRac,
      [EnumMember(Value = "SHARED")]
      Shared,
      [EnumMember(Value = "DEDICATED")]
      Dedicated
  }
}
