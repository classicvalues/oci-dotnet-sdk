/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OptimizerService.Models
{
  /// <summary>
  /// Possible strategy types.
  /// </summary>
  public enum StrategyParameterType {
      [EnumMember(Value = "STRING")]
      String,
      [EnumMember(Value = "BOOLEAN")]
      Boolean,
      [EnumMember(Value = "NUMBER")]
      Number,
      [EnumMember(Value = "DATETIME")]
      Datetime
  }
}
