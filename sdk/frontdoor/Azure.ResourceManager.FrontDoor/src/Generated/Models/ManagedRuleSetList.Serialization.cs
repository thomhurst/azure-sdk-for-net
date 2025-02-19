// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    internal partial class ManagedRuleSetList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ManagedRuleSets))
            {
                writer.WritePropertyName("managedRuleSets"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedRuleSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleSetList DeserializeManagedRuleSetList(JsonElement element)
        {
            Optional<IList<ManagedRuleSet>> managedRuleSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedRuleSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedRuleSet> array = new List<ManagedRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleSet.DeserializeManagedRuleSet(item));
                    }
                    managedRuleSets = array;
                    continue;
                }
            }
            return new ManagedRuleSetList(Optional.ToList(managedRuleSets));
        }
    }
}
