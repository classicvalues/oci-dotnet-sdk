/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.AnalyticsService.Models
{
  /// <summary>
  /// The field to sort by (one column only). Default sort order is
    /// ascending exception of `timeCreated` column (descending).
    /// 
  /// </summary>
  public enum SortBy {
      [EnumMember(Value = "capacityType")]
      CapacityType,
      [EnumMember(Value = "capacityValue")]
      CapacityValue,
      [EnumMember(Value = "featureSet")]
      FeatureSet,
      [EnumMember(Value = "lifecycleState")]
      LifecycleState,
      [EnumMember(Value = "name")]
      Name,
      [EnumMember(Value = "timeCreated")]
      TimeCreated
  }
}
