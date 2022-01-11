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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Configuration options for the Oracle Cloud Agent software running on the instance.
    /// </summary>
    public class InstanceConfigurationLaunchInstanceAgentConfigDetails 
    {
        
        /// <value>
        /// Whether Oracle Cloud Agent can gather performance metrics and monitor the instance using the
        /// monitoring plugins. Default value is false (monitoring plugins are enabled).
        /// <br/>
        /// These are the monitoring plugins: Compute Instance Monitoring
        /// and Custom Logs Monitoring.
        /// <br/>
        /// The monitoring plugins are controlled by this parameter and by the per-plugin
        /// configuration in the `pluginsConfig` object.
        /// <br/>
        /// - If `isMonitoringDisabled` is true, all of the monitoring plugins are disabled, regardless of
        /// the per-plugin configuration.
        /// - If `isMonitoringDisabled` is false, all of the monitoring plugins are enabled. You
        /// can optionally disable individual monitoring plugins by providing a value in the `pluginsConfig`
        /// object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMonitoringDisabled")]
        public System.Nullable<bool> IsMonitoringDisabled { get; set; }
        
        /// <value>
        /// Whether Oracle Cloud Agent can run all the available management plugins.
        /// Default value is false (management plugins are enabled).
        /// <br/>
        /// These are the management plugins: OS Management Service Agent and Compute Instance
        /// Run Command.
        /// <br/>
        /// The management plugins are controlled by this parameter and by the per-plugin
        /// configuration in the `pluginsConfig` object.
        /// <br/>
        /// - If `isManagementDisabled` is true, all of the management plugins are disabled, regardless of
        /// the per-plugin configuration.
        /// - If `isManagementDisabled` is false, all of the management plugins are enabled. You
        /// can optionally disable individual management plugins by providing a value in the `pluginsConfig`
        /// object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isManagementDisabled")]
        public System.Nullable<bool> IsManagementDisabled { get; set; }
        
        /// <value>
        /// Whether Oracle Cloud Agent can run all the available plugins.
        /// This includes the management and monitoring plugins.
        /// <br/>
        /// To get a list of available plugins, use the
        /// {@link #listInstanceagentAvailablePlugins(ListInstanceagentAvailablePluginsRequest) listInstanceagentAvailablePlugins}
        /// operation in the Oracle Cloud Agent API. For more information about the available plugins, see
        /// [Managing Plugins with Oracle Cloud Agent](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/manage-plugins.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areAllPluginsDisabled")]
        public System.Nullable<bool> AreAllPluginsDisabled { get; set; }
        
        /// <value>
        /// The configuration of plugins associated with this instance.
        /// </value>
        [JsonProperty(PropertyName = "pluginsConfig")]
        public System.Collections.Generic.List<InstanceAgentPluginConfigDetails> PluginsConfig { get; set; }
        
    }
}
