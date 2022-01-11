/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ManagementdashboardService.Models;
using Oci.ManagementdashboardService.Requests;
using Oci.ManagementdashboardService.Responses;

namespace Oci.ManagementdashboardService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DashxApis.
    /// </summary>
    public class DashxApisWaiters
    {
        private readonly DashxApisClient client;

        public  DashxApisWaiters(DashxApisClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementDashboardRequest, GetManagementDashboardResponse> ForManagementDashboard(GetManagementDashboardRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForManagementDashboard(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementDashboardRequest, GetManagementDashboardResponse> ForManagementDashboard(GetManagementDashboardRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetManagementDashboardRequest, GetManagementDashboardResponse>(
                request,
                request => client.GetManagementDashboard(request),
                response => targetStates.Contains(response.ManagementDashboard.LifecycleState.Value)
            );
            return new Waiter<GetManagementDashboardRequest, GetManagementDashboardResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementSavedSearchRequest, GetManagementSavedSearchResponse> ForManagementSavedSearch(GetManagementSavedSearchRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForManagementSavedSearch(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementSavedSearchRequest, GetManagementSavedSearchResponse> ForManagementSavedSearch(GetManagementSavedSearchRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetManagementSavedSearchRequest, GetManagementSavedSearchResponse>(
                request,
                request => client.GetManagementSavedSearch(request),
                response => targetStates.Contains(response.ManagementSavedSearch.LifecycleState.Value)
            );
            return new Waiter<GetManagementSavedSearchRequest, GetManagementSavedSearchResponse>(config, agent);
        }
    }
}
