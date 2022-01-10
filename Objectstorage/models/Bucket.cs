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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// A bucket is a container for storing objects in a compartment within a namespace. A bucket is associated with a single compartment.
    /// The compartment has policies that indicate what actions a user can perform on a bucket and all the objects in the bucket. For more
    /// information, see [Managing Buckets](https://docs.cloud.oracle.com/Content/Object/Tasks/managingbuckets.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// talk to an administrator. If you are an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class Bucket 
    {
        
        /// <value>
        /// The Object Storage namespace in which the bucket resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// Example: my-new-bucket1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The compartment ID in which the bucket is authorized.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Arbitrary string keys and values for user-defined metadata.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Metadata is required.")]
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the user who created the bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// The date and time the bucket was created, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.29).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The entity tag (ETag) for the bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Etag is required.")]
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }
                ///
        /// <value>
        /// The type of public access enabled on this bucket.
        /// A bucket is set to `NoPublicAccess` by default, which only allows an authenticated caller to access the
        /// bucket and its contents. When `ObjectRead` is enabled on the bucket, public access is allowed for the
        /// `GetObject`, `HeadObject`, and `ListObjects` operations. When `ObjectReadWithoutList` is enabled on the
        /// bucket, public access is allowed for the `GetObject` and `HeadObject` operations.
        /// 
        /// </value>
        ///
        public enum PublicAccessTypeEnum {
            [EnumMember(Value = "NoPublicAccess")]
            NoPublicAccess,
            [EnumMember(Value = "ObjectRead")]
            ObjectRead,
            [EnumMember(Value = "ObjectReadWithoutList")]
            ObjectReadWithoutList
        };

        /// <value>
        /// The type of public access enabled on this bucket.
        /// A bucket is set to `NoPublicAccess` by default, which only allows an authenticated caller to access the
        /// bucket and its contents. When `ObjectRead` is enabled on the bucket, public access is allowed for the
        /// `GetObject`, `HeadObject`, and `ListObjects` operations. When `ObjectReadWithoutList` is enabled on the
        /// bucket, public access is allowed for the `GetObject` and `HeadObject` operations.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicAccessType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PublicAccessTypeEnum> PublicAccessType { get; set; }
                ///
        /// <value>
        /// The storage tier type assigned to the bucket. A bucket is set to `Standard` tier by default, which means
        /// objects uploaded or copied to the bucket will be in the standard storage tier. When the `Archive` tier type
        /// is set explicitly for a bucket, objects uploaded or copied to the bucket will be stored in archive storage.
        /// The `storageTier` property is immutable after bucket is created.
        /// 
        /// </value>
        ///
        public enum StorageTierEnum {
            [EnumMember(Value = "Standard")]
            Standard,
            [EnumMember(Value = "Archive")]
            Archive
        };

        /// <value>
        /// The storage tier type assigned to the bucket. A bucket is set to `Standard` tier by default, which means
        /// objects uploaded or copied to the bucket will be in the standard storage tier. When the `Archive` tier type
        /// is set explicitly for a bucket, objects uploaded or copied to the bucket will be stored in archive storage.
        /// The `storageTier` property is immutable after bucket is created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageTier")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageTierEnum> StorageTier { get; set; }
        
        /// <value>
        /// Whether or not events are emitted for object state changes in this bucket. By default, `objectEventsEnabled` is
        /// set to `false`. Set `objectEventsEnabled` to `true` to emit events for object state changes. For more information
        /// about events, see [Overview of Events](https://docs.cloud.oracle.com/Content/Events/Concepts/eventsoverview.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectEventsEnabled")]
        public System.Nullable<bool> ObjectEventsEnabled { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a master encryption key used to call the Key Management
        /// service to generate a data encryption key or to encrypt or decrypt a data encryption key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The entity tag (ETag) for the live object lifecycle policy on the bucket.
        /// </value>
        [JsonProperty(PropertyName = "objectLifecyclePolicyEtag")]
        public string ObjectLifecyclePolicyEtag { get; set; }
        
        /// <value>
        /// The approximate number of objects in the bucket. Count statistics are reported periodically. You will see a
        /// lag between what is displayed and the actual object count.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "approximateCount")]
        public System.Nullable<long> ApproximateCount { get; set; }
        
        /// <value>
        /// The approximate total size in bytes of all objects in the bucket. Size statistics are reported periodically. You will
        /// see a lag between what is displayed and the actual size of the bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "approximateSize")]
        public System.Nullable<long> ApproximateSize { get; set; }
        
        /// <value>
        /// Whether or not this bucket is a replication source. By default, `replicationEnabled` is set to `false`. This will
        /// be set to 'true' when you create a replication policy for the bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationEnabled")]
        public System.Nullable<bool> ReplicationEnabled { get; set; }
        
        /// <value>
        /// Whether or not this bucket is read only. By default, `isReadOnly` is set to `false`. This will
        /// be set to 'true' when this bucket is configured as a destination in a replication policy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isReadOnly")]
        public System.Nullable<bool> IsReadOnly { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The versioning status on the bucket. A bucket is created with versioning `Disabled` by default.
        /// For versioning `Enabled`, objects are protected from overwrites and deletes, by maintaining their version history. When versioning is `Suspended`, the previous versions will still remain but new versions will no longer be created when overwitten or deleted.
        /// 
        /// </value>
        ///
        public enum VersioningEnum {
            [EnumMember(Value = "Enabled")]
            Enabled,
            [EnumMember(Value = "Suspended")]
            Suspended,
            [EnumMember(Value = "Disabled")]
            Disabled
        };

        /// <value>
        /// The versioning status on the bucket. A bucket is created with versioning `Disabled` by default.
        /// For versioning `Enabled`, objects are protected from overwrites and deletes, by maintaining their version history. When versioning is `Suspended`, the previous versions will still remain but new versions will no longer be created when overwitten or deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "versioning")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VersioningEnum> Versioning { get; set; }
                ///
        /// <value>
        /// The auto tiering status on the bucket. A bucket is created with auto tiering `Disabled` by default.
        /// For auto tiering `InfrequentAccess`, objects are transitioned automatically between the 'Standard'
        /// and 'InfrequentAccess' tiers based on the access pattern of the objects.
        /// 
        /// </value>
        ///
        public enum AutoTieringEnum {
            [EnumMember(Value = "Disabled")]
            Disabled,
            [EnumMember(Value = "InfrequentAccess")]
            InfrequentAccess
        };

        /// <value>
        /// The auto tiering status on the bucket. A bucket is created with auto tiering `Disabled` by default.
        /// For auto tiering `InfrequentAccess`, objects are transitioned automatically between the 'Standard'
        /// and 'InfrequentAccess' tiers based on the access pattern of the objects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autoTiering")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AutoTieringEnum> AutoTiering { get; set; }
        
    }
}
