/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of ObjectStorage where multiple pages of data may be fetched.
    /// Two styles of enumerators are supported:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Enumerating over the Response objects returned by the list operation. These are referred to as ResponseEnumerators, and the methods are suffixed with ResponseEnumerator. For example: listUsersResponseEnumerator.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Enumerating over the resources/records being listed. These are referred to as RecordEnumerators, and the methods are suffixed with RecordEnumerator. For example: listUsersRecordEnumerator.
    /// </description>
    /// </item>
    /// </list>
    /// These enumerators abstract away the need to write code to manually handle pagination via looping and using the page tokens.
    /// They will automatically fetch more data from the service when required.
    /// <br/>
    /// <br/>
    /// As an example, if we were using the ListUsers operation in IdentityService, then the iterator returned by calling a
    /// ResponseEnumerator method would iterate over the ListUsersResponse objects returned by each ListUsers call, whereas the enumerables
    /// returned by calling a RecordEnumerator method would iterate over the User records and we don't have to deal with ListUsersResponse objects at all.
    /// In either case, pagination will be automatically handled so we can iterate until there are no more responses or no more resources/records available.
    /// </summary>
    public class ObjectStoragePaginators
    {
        private readonly ObjectStorageClient client;

        public ObjectStoragePaginators(ObjectStorageClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListBuckets operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListBucketsResponse> ListBucketsResponseEnumerator(ListBucketsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListBucketsRequest, ListBucketsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListBuckets(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the BucketSummary objects
        /// contained in responses from the ListBuckets operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<BucketSummary> ListBucketsRecordEnumerator(ListBucketsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListBucketsRequest, ListBucketsResponse, BucketSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListBuckets(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListMultipartUploadParts operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListMultipartUploadPartsResponse> ListMultipartUploadPartsResponseEnumerator(ListMultipartUploadPartsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListMultipartUploadPartsRequest, ListMultipartUploadPartsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListMultipartUploadParts(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the MultipartUploadPartSummary objects
        /// contained in responses from the ListMultipartUploadParts operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<MultipartUploadPartSummary> ListMultipartUploadPartsRecordEnumerator(ListMultipartUploadPartsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListMultipartUploadPartsRequest, ListMultipartUploadPartsResponse, MultipartUploadPartSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListMultipartUploadParts(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListMultipartUploads operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListMultipartUploadsResponse> ListMultipartUploadsResponseEnumerator(ListMultipartUploadsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListMultipartUploadsRequest, ListMultipartUploadsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListMultipartUploads(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the MultipartUpload objects
        /// contained in responses from the ListMultipartUploads operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<MultipartUpload> ListMultipartUploadsRecordEnumerator(ListMultipartUploadsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListMultipartUploadsRequest, ListMultipartUploadsResponse, MultipartUpload>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListMultipartUploads(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListObjectVersions operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListObjectVersionsResponse> ListObjectVersionsResponseEnumerator(ListObjectVersionsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListObjectVersionsRequest, ListObjectVersionsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListObjectVersions(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ObjectVersionSummary objects
        /// contained in responses from the ListObjectVersions operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ObjectVersionSummary> ListObjectVersionsRecordEnumerator(ListObjectVersionsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListObjectVersionsRequest, ListObjectVersionsResponse, ObjectVersionSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListObjectVersions(request, retryConfiguration, cancellationToken),
                response => response.ObjectVersionCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListObjects operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListObjectsResponse> ListObjectsResponseEnumerator(ListObjectsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListObjectsRequest, ListObjectsResponse>(
                response => response.ListObjects.NextStartWith,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Start = input;
                    }
                    return request;
                },
                request => client.ListObjects(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ObjectSummary objects
        /// contained in responses from the ListObjects operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ObjectSummary> ListObjectsRecordEnumerator(ListObjectsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListObjectsRequest, ListObjectsResponse, ObjectSummary>(
                response => response.ListObjects.NextStartWith,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Start = input;
                    }
                    return request;
                },
                request => client.ListObjects(request, retryConfiguration, cancellationToken),
                response => response.ListObjects.Objects
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListPreauthenticatedRequests operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListPreauthenticatedRequestsResponse> ListPreauthenticatedRequestsResponseEnumerator(ListPreauthenticatedRequestsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListPreauthenticatedRequestsRequest, ListPreauthenticatedRequestsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListPreauthenticatedRequests(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the PreauthenticatedRequestSummary objects
        /// contained in responses from the ListPreauthenticatedRequests operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<PreauthenticatedRequestSummary> ListPreauthenticatedRequestsRecordEnumerator(ListPreauthenticatedRequestsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListPreauthenticatedRequestsRequest, ListPreauthenticatedRequestsResponse, PreauthenticatedRequestSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListPreauthenticatedRequests(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListReplicationPolicies operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListReplicationPoliciesResponse> ListReplicationPoliciesResponseEnumerator(ListReplicationPoliciesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListReplicationPoliciesRequest, ListReplicationPoliciesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListReplicationPolicies(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ReplicationPolicySummary objects
        /// contained in responses from the ListReplicationPolicies operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ReplicationPolicySummary> ListReplicationPoliciesRecordEnumerator(ListReplicationPoliciesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListReplicationPoliciesRequest, ListReplicationPoliciesResponse, ReplicationPolicySummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListReplicationPolicies(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListReplicationSources operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListReplicationSourcesResponse> ListReplicationSourcesResponseEnumerator(ListReplicationSourcesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListReplicationSourcesRequest, ListReplicationSourcesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListReplicationSources(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ReplicationSource objects
        /// contained in responses from the ListReplicationSources operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ReplicationSource> ListReplicationSourcesRecordEnumerator(ListReplicationSourcesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListReplicationSourcesRequest, ListReplicationSourcesResponse, ReplicationSource>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListReplicationSources(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListRetentionRules operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListRetentionRulesResponse> ListRetentionRulesResponseEnumerator(ListRetentionRulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListRetentionRulesRequest, ListRetentionRulesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListRetentionRules(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the RetentionRuleSummary objects
        /// contained in responses from the ListRetentionRules operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<RetentionRuleSummary> ListRetentionRulesRecordEnumerator(ListRetentionRulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListRetentionRulesRequest, ListRetentionRulesResponse, RetentionRuleSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListRetentionRules(request, retryConfiguration, cancellationToken),
                response => response.RetentionRuleCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListWorkRequestErrors operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListWorkRequestErrorsResponse> ListWorkRequestErrorsResponseEnumerator(ListWorkRequestErrorsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListWorkRequestErrorsRequest, ListWorkRequestErrorsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestErrors(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the WorkRequestError objects
        /// contained in responses from the ListWorkRequestErrors operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<WorkRequestError> ListWorkRequestErrorsRecordEnumerator(ListWorkRequestErrorsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListWorkRequestErrorsRequest, ListWorkRequestErrorsResponse, WorkRequestError>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestErrors(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListWorkRequestLogs operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListWorkRequestLogsResponse> ListWorkRequestLogsResponseEnumerator(ListWorkRequestLogsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListWorkRequestLogsRequest, ListWorkRequestLogsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestLogs(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the WorkRequestLogEntry objects
        /// contained in responses from the ListWorkRequestLogs operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<WorkRequestLogEntry> ListWorkRequestLogsRecordEnumerator(ListWorkRequestLogsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListWorkRequestLogsRequest, ListWorkRequestLogsResponse, WorkRequestLogEntry>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestLogs(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListWorkRequests operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListWorkRequestsResponse> ListWorkRequestsResponseEnumerator(ListWorkRequestsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListWorkRequestsRequest, ListWorkRequestsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequests(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the WorkRequestSummary objects
        /// contained in responses from the ListWorkRequests operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<WorkRequestSummary> ListWorkRequestsRecordEnumerator(ListWorkRequestsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListWorkRequestsRequest, ListWorkRequestsResponse, WorkRequestSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequests(request, retryConfiguration, cancellationToken),
                response => response.Items
            );
        }

    }
}
