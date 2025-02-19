// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    internal partial class NextBillingCycleDetails
    {
        internal static NextBillingCycleDetails DeserializeNextBillingCycleDetails(JsonElement element)
        {
            Optional<string> billingFrequency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingFrequency"u8))
                {
                    billingFrequency = property.Value.GetString();
                    continue;
                }
            }
            return new NextBillingCycleDetails(billingFrequency.Value);
        }
    }
}
