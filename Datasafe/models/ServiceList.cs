/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatasafeService.Models
{
  /// <summary>
  /// List of (Oracle) Data Safe services, the only production service is DataSafe, the other services are used in devtest.
  /// </summary>
  public enum ServiceList {
      [EnumMember(Value = "DataSafe")]
      DataSafe,
      [EnumMember(Value = "DataSafe-dev")]
      DataSafeDev,
      [EnumMember(Value = "DataSafe-dev1")]
      DataSafeDev1,
      [EnumMember(Value = "DataSafe-dev2")]
      DataSafeDev2,
      [EnumMember(Value = "DataSafe-dev3")]
      DataSafeDev3,
      [EnumMember(Value = "DataSafe-dev4")]
      DataSafeDev4,
      [EnumMember(Value = "DataSafe-dev5")]
      DataSafeDev5,
      [EnumMember(Value = "DataSafe-dev6")]
      DataSafeDev6,
      [EnumMember(Value = "DataSafe-dev7")]
      DataSafeDev7,
      [EnumMember(Value = "DataSafe-dev8")]
      DataSafeDev8,
      [EnumMember(Value = "DataSafe-lrg1")]
      DataSafeLrg1,
      [EnumMember(Value = "DataSafe-lrg2")]
      DataSafeLrg2,
      [EnumMember(Value = "DataSafe-lrg3")]
      DataSafeLrg3,
      [EnumMember(Value = "DataSafe-lrg4")]
      DataSafeLrg4,
      [EnumMember(Value = "DataSafe-ptest")]
      DataSafePtest,
      [EnumMember(Value = "DataSafe-stest")]
      DataSafeStest,
      [EnumMember(Value = "DataSafe-stage")]
      DataSafeStage
  }
}
