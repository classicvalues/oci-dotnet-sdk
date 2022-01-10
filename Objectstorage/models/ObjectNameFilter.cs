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
    /// A filter that compares object names to a set of prefixes or patterns to determine if a rule applies to a
    /// given object. The filter can contain include glob patterns, exclude glob patterns and inclusion prefixes.
    /// The inclusion prefixes property is kept for backward compatibility. It is recommended to use inclusion patterns
    /// instead of prefixes. Exclusions take precedence over inclusions.
    /// 
    /// </summary>
    public class ObjectNameFilter 
    {
        
        /// <value>
        /// An array of object name prefixes that the rule will apply to. An empty array means to include all objects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "inclusionPrefixes")]
        public System.Collections.Generic.List<string> InclusionPrefixes { get; set; }
        
        /// <value>
        /// An array of glob patterns to match the object names to include. An empty array includes all objects in the
        /// bucket. Exclusion patterns take precedence over inclusion patterns.
        /// A Glob pattern is a sequence of characters to match text. Any character that appears in the pattern, other
        /// than the special pattern characters described below, matches itself.
        ///     Glob patterns must be between 1 and 1024 characters.
        /// <br/>
        ///     The special pattern characters have the following meanings:
        /// <br/>
        ///     \\           Escapes the following character
        ///     *           Matches any string of characters.
        ///     ?           Matches any single character .
        ///     [...]       Matches a group of characters. A group of characters can be:
        ///                     A set of characters, for Example: [Zafg9@]. This matches any character in the brackets.                    A range of characters, for
        /// </value>
        [JsonProperty(PropertyName = "inclusionPatterns")]
        public System.Collections.Generic.List<string> InclusionPatterns { get; set; }
        
        /// <value>
        /// An array of glob patterns to match the object names to exclude. An empty array is ignored. Exclusion
        /// patterns take precedence over inclusion patterns.
        /// A Glob pattern is a sequence of characters to match text. Any character that appears in the pattern, other
        /// than the special pattern characters described below, matches itself.
        ///     Glob patterns must be between 1 and 1024 characters.
        /// <br/>
        ///     The special pattern characters have the following meanings:
        /// <br/>
        ///     \\           Escapes the following character
        ///     *           Matches any string of characters.
        ///     ?           Matches any single character .
        ///     [...]       Matches a group of characters. A group of characters can be:
        ///                     A set of characters, for Example: [Zafg9@]. This matches any character in the brackets.                    A range of characters, for
        /// </value>
        [JsonProperty(PropertyName = "exclusionPatterns")]
        public System.Collections.Generic.List<string> ExclusionPatterns { get; set; }
        
    }
}
