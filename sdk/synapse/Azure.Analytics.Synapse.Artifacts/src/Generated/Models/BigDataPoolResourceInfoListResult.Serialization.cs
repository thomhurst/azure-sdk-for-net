// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(BigDataPoolResourceInfoListResultConverter))]
    public partial class BigDataPoolResourceInfoListResult
    {
        internal static BigDataPoolResourceInfoListResult DeserializeBigDataPoolResourceInfoListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<BigDataPoolResourceInfo>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BigDataPoolResourceInfo> array = new List<BigDataPoolResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BigDataPoolResourceInfo.DeserializeBigDataPoolResourceInfo(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BigDataPoolResourceInfoListResult(nextLink.Value, Optional.ToList(value));
        }

        internal partial class BigDataPoolResourceInfoListResultConverter : JsonConverter<BigDataPoolResourceInfoListResult>
        {
            public override void Write(Utf8JsonWriter writer, BigDataPoolResourceInfoListResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override BigDataPoolResourceInfoListResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBigDataPoolResourceInfoListResult(document.RootElement);
            }
        }
    }
}
