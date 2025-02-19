// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class AvailableCognitiveServicesSkuResult
    {
        internal static AvailableCognitiveServicesSkuResult DeserializeAvailableCognitiveServicesSkuResult(JsonElement element)
        {
            IReadOnlyList<AvailableCognitiveServicesSku> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AvailableCognitiveServicesSku> array = new List<AvailableCognitiveServicesSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableCognitiveServicesSku.DeserializeAvailableCognitiveServicesSku(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AvailableCognitiveServicesSkuResult(value, nextLink.Value);
        }
    }
}
