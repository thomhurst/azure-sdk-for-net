// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionEventSummary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ConsumptionEventSummary DeserializeConsumptionEventSummary(JsonElement element)
        {
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> transactionDate = default;
            Optional<string> description = default;
            Optional<ConsumptionAmount> newCredit = default;
            Optional<ConsumptionAmount> adjustments = default;
            Optional<ConsumptionAmount> creditExpired = default;
            Optional<ConsumptionAmount> charges = default;
            Optional<ConsumptionAmount> closedBalance = default;
            Optional<ConsumptionEventType> eventType = default;
            Optional<string> invoiceNumber = default;
            Optional<ResourceIdentifier> billingProfileId = default;
            Optional<string> billingProfileDisplayName = default;
            Optional<ResourceIdentifier> lotId = default;
            Optional<string> lotSource = default;
            Optional<ConsumptionAmount> canceledCredit = default;
            Optional<string> creditCurrency = default;
            Optional<string> billingCurrency = default;
            Optional<ConsumptionReseller> reseller = default;
            Optional<ConsumptionAmountWithExchangeRate> creditExpiredInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> newCreditInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> adjustmentsInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> chargesInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> closedBalanceInBillingCurrency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("transactionDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            transactionDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("newCredit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newCredit = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adjustments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adjustments = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creditExpired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creditExpired = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("charges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            charges = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            closedBalance = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventType = new ConsumptionEventType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("invoiceNumber"u8))
                        {
                            invoiceNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingProfileId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingProfileDisplayName"u8))
                        {
                            billingProfileDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lotId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lotId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lotSource"u8))
                        {
                            lotSource = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("canceledCredit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            canceledCredit = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creditCurrency"u8))
                        {
                            creditCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reseller = ConsumptionReseller.DeserializeConsumptionReseller(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creditExpiredInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creditExpiredInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("newCreditInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newCreditInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adjustmentsInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adjustmentsInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("chargesInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            chargesInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalanceInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            closedBalanceInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionEventSummary(id, name, type, systemData.Value, Optional.ToNullable(transactionDate), description.Value, newCredit.Value, adjustments.Value, creditExpired.Value, charges.Value, closedBalance.Value, Optional.ToNullable(eventType), invoiceNumber.Value, billingProfileId.Value, billingProfileDisplayName.Value, lotId.Value, lotSource.Value, canceledCredit.Value, creditCurrency.Value, billingCurrency.Value, reseller.Value, creditExpiredInBillingCurrency.Value, newCreditInBillingCurrency.Value, adjustmentsInBillingCurrency.Value, chargesInBillingCurrency.Value, closedBalanceInBillingCurrency.Value, Optional.ToNullable(eTag));
        }
    }
}
