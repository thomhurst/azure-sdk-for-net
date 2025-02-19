// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRuleRunPlaybookAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActionConfiguration))
            {
                writer.WritePropertyName("actionConfiguration"u8);
                writer.WriteObjectValue(ActionConfiguration);
            }
            writer.WritePropertyName("order"u8);
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static AutomationRuleRunPlaybookAction DeserializeAutomationRuleRunPlaybookAction(JsonElement element)
        {
            Optional<AutomationRuleRunPlaybookActionProperties> actionConfiguration = default;
            int order = default;
            ActionType actionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionConfiguration = AutomationRuleRunPlaybookActionProperties.DeserializeAutomationRuleRunPlaybookActionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AutomationRuleRunPlaybookAction(order, actionType, actionConfiguration.Value);
        }
    }
}
