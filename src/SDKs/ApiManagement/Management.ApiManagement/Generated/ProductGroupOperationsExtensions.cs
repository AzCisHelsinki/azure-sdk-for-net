// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProductGroupOperations.
    /// </summary>
    public static partial class ProductGroupOperationsExtensions
    {
            /// <summary>
            /// Lists the collection of developer groups associated with the specified
            /// product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<GroupContract> ListByProduct(this IProductGroupOperations operations, string resourceGroupName, string serviceName, string productId, ODataQuery<GroupContract> odataQuery = default(ODataQuery<GroupContract>))
            {
                return ((IProductGroupOperations)operations).ListByProductAsync(resourceGroupName, serviceName, productId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the collection of developer groups associated with the specified
            /// product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GroupContract>> ListByProductAsync(this IProductGroupOperations operations, string resourceGroupName, string serviceName, string productId, ODataQuery<GroupContract> odataQuery = default(ODataQuery<GroupContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProductWithHttpMessagesAsync(resourceGroupName, serviceName, productId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds the association between the specified developer group with the
            /// specified product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='groupId'>
            /// Group identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static GroupContract CreateOrUpdate(this IProductGroupOperations operations, string resourceGroupName, string serviceName, string productId, string groupId)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, productId, groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds the association between the specified developer group with the
            /// specified product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='groupId'>
            /// Group identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GroupContract> CreateOrUpdateAsync(this IProductGroupOperations operations, string resourceGroupName, string serviceName, string productId, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, productId, groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the association between the specified group and product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='groupId'>
            /// Group identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            public static void Delete(this IProductGroupOperations operations, string resourceGroupName, string serviceName, string productId, string groupId)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, productId, groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the association between the specified group and product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='productId'>
            /// Product identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='groupId'>
            /// Group identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProductGroupOperations operations, string resourceGroupName, string serviceName, string productId, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, productId, groupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the collection of developer groups associated with the specified
            /// product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GroupContract> ListByProductNext(this IProductGroupOperations operations, string nextPageLink)
            {
                return operations.ListByProductNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the collection of developer groups associated with the specified
            /// product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GroupContract>> ListByProductNextAsync(this IProductGroupOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProductNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}