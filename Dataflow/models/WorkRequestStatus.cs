/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DataflowService.Models
{
  /// <summary>
  /// The status of the work request.
    /// 
  /// </summary>
  public enum WorkRequestStatus {
      [EnumMember(Value = "ACCEPTED")]
      Accepted,
      [EnumMember(Value = "CANCELLED")]
      Cancelled,
      [EnumMember(Value = "CANCELLING")]
      Cancelling,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "INPROGRESS")]
      Inprogress,
      [EnumMember(Value = "SUCCEEDED")]
      Succeeded
  }
}
