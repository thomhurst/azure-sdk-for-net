// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class extending from the ManagementGroupBillingPeriodResource in Azure.ResourceManager.Consumption along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="ManagementGroupBillingPeriodConsumptionResource" /> from a <see cref="ResourceIdentifier" /> with a resource type of Microsoft.Billing/billingPeriods.
    /// </summary>
    public partial class ManagementGroupBillingPeriodConsumptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementGroupBillingPeriodConsumptionResource"/> instance. </summary>
        internal static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string billingPeriodName)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _aggregatedCostClientDiagnostics;
        private readonly AggregatedCostRestOperations _aggregatedCostRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupBillingPeriodConsumptionResource"/> class for mocking. </summary>
        protected ManagementGroupBillingPeriodConsumptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupBillingPeriodConsumptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroupBillingPeriodConsumptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _aggregatedCostClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _aggregatedCostRestClient = new AggregatedCostRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingPeriods";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Provides the aggregate cost of a management group and all child management groups by specified billing period
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}/providers/Microsoft.Consumption/aggregatedCost</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AggregatedCost_GetForBillingPeriodByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConsumptionAggregatedCostResult>> GetAggregatedCostAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _aggregatedCostClientDiagnostics.CreateScope("ManagementGroupBillingPeriodConsumptionResource.GetAggregatedCost");
            scope.Start();
            try
            {
                var response = await _aggregatedCostRestClient.GetForBillingPeriodByManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the aggregate cost of a management group and all child management groups by specified billing period
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}/providers/Microsoft.Consumption/aggregatedCost</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AggregatedCost_GetForBillingPeriodByManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConsumptionAggregatedCostResult> GetAggregatedCost(CancellationToken cancellationToken = default)
        {
            using var scope = _aggregatedCostClientDiagnostics.CreateScope("ManagementGroupBillingPeriodConsumptionResource.GetAggregatedCost");
            scope.Start();
            try
            {
                var response = _aggregatedCostRestClient.GetForBillingPeriodByManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
