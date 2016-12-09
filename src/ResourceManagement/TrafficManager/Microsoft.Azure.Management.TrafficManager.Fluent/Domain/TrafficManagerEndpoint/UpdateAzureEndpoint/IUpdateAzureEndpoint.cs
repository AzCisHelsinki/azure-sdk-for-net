// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Trafficmanager.Fluent.TrafficManagerEndpoint.UpdateAzureEndpoint
{
    using Microsoft.Azure.Management.Trafficmanager.Fluent.TrafficManagerEndpoint.Update;

    /// <summary>
    /// The entirety of an Azure endpoint update as a part of parent traffic manager profile profile update.
    /// </summary>
    public interface IUpdateAzureEndpoint  :
        IWithAzureResource,
        IUpdate
    {
    }
}