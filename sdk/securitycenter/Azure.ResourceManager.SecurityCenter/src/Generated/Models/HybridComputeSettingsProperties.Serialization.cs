// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class HybridComputeSettingsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("autoProvision"u8);
            writer.WriteStringValue(AutoProvision.ToString());
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(ProxyServer))
            {
                writer.WritePropertyName("proxyServer"u8);
                writer.WriteObjectValue(ProxyServer);
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                writer.WritePropertyName("servicePrincipal"u8);
                writer.WriteObjectValue(ServicePrincipal);
            }
            writer.WriteEndObject();
        }

        internal static HybridComputeSettingsProperties DeserializeHybridComputeSettingsProperties(JsonElement element)
        {
            Optional<HybridComputeProvisioningState> hybridComputeProvisioningState = default;
            AutoProvisionState autoProvision = default;
            Optional<string> resourceGroupName = default;
            Optional<string> region = default;
            Optional<ProxyServerProperties> proxyServer = default;
            Optional<ServicePrincipalProperties> servicePrincipal = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hybridComputeProvisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hybridComputeProvisioningState = new HybridComputeProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoProvision"u8))
                {
                    autoProvision = new AutoProvisionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("proxyServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    proxyServer = ProxyServerProperties.DeserializeProxyServerProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("servicePrincipal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePrincipal = ServicePrincipalProperties.DeserializeServicePrincipalProperties(property.Value);
                    continue;
                }
            }
            return new HybridComputeSettingsProperties(Optional.ToNullable(hybridComputeProvisioningState), autoProvision, resourceGroupName.Value, region.Value, proxyServer.Value, servicePrincipal.Value);
        }
    }
}
