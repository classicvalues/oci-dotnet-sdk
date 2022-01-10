/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.OcvpService.Models;
using Oci.OcvpService.Requests;
using Oci.OcvpService.Responses;

namespace Oci.OcvpService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Sddc.
    /// </summary>
    public class SddcWaiters
    {
        private readonly SddcClient client;

        public  SddcWaiters(SddcClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSddcRequest, GetSddcResponse> ForSddc(GetSddcRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForSddc(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSddcRequest, GetSddcResponse> ForSddc(GetSddcRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetSddcRequest, GetSddcResponse>(
                request,
                request => client.GetSddc(request),
                response => targetStates.Contains(response.Sddc.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Deleted)
            );
            return new Waiter<GetSddcRequest, GetSddcResponse>(config, agent);
        }
    }
}
