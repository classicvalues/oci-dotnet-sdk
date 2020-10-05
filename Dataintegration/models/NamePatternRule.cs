/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// This rule projects fields by a name pattern, for example it may start with STR_ or end with _DATE. This is defined using a regular expression.
    /// </summary>
    public class NamePatternRule : ProjectionRule
    {
        
        /// <value>
        /// Specifies whether to skip remaining rules when a match is found.
        /// </value>
        [JsonProperty(PropertyName = "isSkipRemainingRulesOnMatch")]
        public System.Nullable<bool> IsSkipRemainingRulesOnMatch { get; set; }

        /// <value>
        /// Reference to a typed object. This can be either a key value to an object within the document, a shall referenced to a `TypedObject`, or a full `TypedObject` definition.
        /// </value>
        [JsonProperty(PropertyName = "scope")]
        public System.Object Scope { get; set; }

        /// <value>
        /// Specifies whether to cascade or not.
        /// </value>
        [JsonProperty(PropertyName = "isCascade")]
        public System.Nullable<bool> IsCascade { get; set; }
        ///
        /// <value>
        /// The pattern matching strategy.
        /// </value>
        ///
        public enum MatchingStrategyEnum {
            [EnumMember(Value = "NAME_OR_TAGS")]
            NameOrTags,
            [EnumMember(Value = "TAGS_ONLY")]
            TagsOnly,
            [EnumMember(Value = "NAME_ONLY")]
            NameOnly
        };

        /// <value>
        /// The pattern matching strategy.
        /// </value>
        [JsonProperty(PropertyName = "matchingStrategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MatchingStrategyEnum> MatchingStrategy { get; set; }

        /// <value>
        /// Specifies if the rule is case sensitive.
        /// </value>
        [JsonProperty(PropertyName = "isCaseSensitive")]
        public System.Nullable<bool> IsCaseSensitive { get; set; }
        ///
        /// <value>
        /// The rule type.
        /// </value>
        ///
        public enum RuleTypeEnum {
            [EnumMember(Value = "INCLUDE")]
            Include,
            [EnumMember(Value = "EXCLUDE")]
            Exclude
        };

        /// <value>
        /// The rule type.
        /// </value>
        [JsonProperty(PropertyName = "ruleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RuleTypeEnum> RuleType { get; set; }

        /// <value>
        /// The rule pattern.
        /// </value>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }
    }
}
