/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.KeymanagementService.Models;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;

namespace Oci.KeymanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of KmsManagement.
    /// </summary>
    public class KmsManagementWaiters
    {
        private readonly KmsManagementClient client;

        public  KmsManagementWaiters(KmsManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetKeyRequest, GetKeyResponse> ForKey(GetKeyRequest request, params Key.LifecycleStateEnum[] targetStates)
        {
            return this.ForKey(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetKeyRequest, GetKeyResponse> ForKey(GetKeyRequest request, WaiterConfiguration config, params Key.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetKeyRequest, GetKeyResponse>(
                request,
                request => client.GetKey(request),
                response => targetStates.Contains(response.Key.LifecycleState.Value),
                targetStates.Contains(Key.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetKeyRequest, GetKeyResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetKeyVersionRequest, GetKeyVersionResponse> ForKeyVersion(GetKeyVersionRequest request, params KeyVersion.LifecycleStateEnum[] targetStates)
        {
            return this.ForKeyVersion(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetKeyVersionRequest, GetKeyVersionResponse> ForKeyVersion(GetKeyVersionRequest request, WaiterConfiguration config, params KeyVersion.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetKeyVersionRequest, GetKeyVersionResponse>(
                request,
                request => client.GetKeyVersion(request),
                response => targetStates.Contains(response.KeyVersion.LifecycleState.Value),
                targetStates.Contains(KeyVersion.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetKeyVersionRequest, GetKeyVersionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWrappingKeyRequest, GetWrappingKeyResponse> ForWrappingKey(GetWrappingKeyRequest request, params WrappingKey.LifecycleStateEnum[] targetStates)
        {
            return this.ForWrappingKey(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWrappingKeyRequest, GetWrappingKeyResponse> ForWrappingKey(GetWrappingKeyRequest request, WaiterConfiguration config, params WrappingKey.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetWrappingKeyRequest, GetWrappingKeyResponse>(
                request,
                request => client.GetWrappingKey(request),
                response => targetStates.Contains(response.WrappingKey.LifecycleState.Value),
                targetStates.Contains(WrappingKey.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetWrappingKeyRequest, GetWrappingKeyResponse>(config, agent);
        }
    }
}
