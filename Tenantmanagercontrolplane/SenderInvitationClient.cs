/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.TenantmanagercontrolplaneService.Requests;
using Oci.TenantmanagercontrolplaneService.Responses;

namespace Oci.TenantmanagercontrolplaneService
{
    /// <summary>Service client instance for SenderInvitation.</summary>
    public class SenderInvitationClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20200801";

        public SenderInvitationPaginators Paginators { get; }

        public SenderInvitationWaiters Waiters { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public SenderInvitationClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "SENDERINVITATION",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://organizations.{region}.oci.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
            Paginators = new SenderInvitationPaginators(this);
            Waiters = new SenderInvitationWaiters(this);
        }

        /// <summary>
        /// Cancels a sender invitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/tenantmanagercontrolplane/CancelSenderInvitation.cs.html">here</a> to see an example of how to use CancelSenderInvitation API.</example>
        public async Task<CancelSenderInvitationResponse> CancelSenderInvitation(CancelSenderInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called cancelSenderInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/senderInvitations/{senderInvitationId}/actions/cancel".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<CancelSenderInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"CancelSenderInvitation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Creates a sender invitation and asynchronously sends the invitation to the recipient.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/tenantmanagercontrolplane/CreateSenderInvitation.cs.html">here</a> to see an example of how to use CreateSenderInvitation API.</example>
        public async Task<CreateSenderInvitationResponse> CreateSenderInvitation(CreateSenderInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called createSenderInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/senderInvitations".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<CreateSenderInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"CreateSenderInvitation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Gets information about the sender invitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/tenantmanagercontrolplane/GetSenderInvitation.cs.html">here</a> to see an example of how to use GetSenderInvitation API.</example>
        public async Task<GetSenderInvitationResponse> GetSenderInvitation(GetSenderInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called getSenderInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/senderInvitations/{senderInvitationId}".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<GetSenderInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetSenderInvitation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Return a (paginated) list of sender invitations.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/tenantmanagercontrolplane/ListSenderInvitations.cs.html">here</a> to see an example of how to use ListSenderInvitations API.</example>
        public async Task<ListSenderInvitationsResponse> ListSenderInvitations(ListSenderInvitationsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called listSenderInvitations");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/senderInvitations".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<ListSenderInvitationsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListSenderInvitations failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Updates the SenderInvitation.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/tenantmanagercontrolplane/UpdateSenderInvitation.cs.html">here</a> to see an example of how to use UpdateSenderInvitation API.</example>
        public async Task<UpdateSenderInvitationResponse> UpdateSenderInvitation(UpdateSenderInvitationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called updateSenderInvitation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/senderInvitations/{senderInvitationId}".Trim('/')));
            HttpMethod method = new HttpMethod("PUT");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage);

                return Converter.FromHttpResponseMessage<UpdateSenderInvitationResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"UpdateSenderInvitation failed with error: {e.Message}");
                throw;
            }
        }

    }
}
