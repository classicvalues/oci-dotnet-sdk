/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementService.Models
{
  /// <summary>
  /// Possible checksum types
  /// </summary>
  public enum ChecksumTypes {
      [EnumMember(Value = "SHA1")]
      Sha1,
      [EnumMember(Value = "SHA256")]
      Sha256,
      [EnumMember(Value = "SHA384")]
      Sha384,
      [EnumMember(Value = "SHA512")]
      Sha512
  }
}
