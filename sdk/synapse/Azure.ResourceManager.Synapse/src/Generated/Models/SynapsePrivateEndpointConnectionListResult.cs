// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class SynapsePrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionListResult. </summary>
        internal SynapsePrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<SynapsePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapsePrivateEndpointConnectionListResult(IReadOnlyList<SynapsePrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapsePrivateEndpointConnectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
