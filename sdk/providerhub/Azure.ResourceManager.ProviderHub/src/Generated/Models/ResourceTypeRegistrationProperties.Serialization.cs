// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeRegistrationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingType))
            {
                writer.WritePropertyName("routingType"u8);
                writer.WriteStringValue(RoutingType.Value.ToString());
            }
            if (Optional.IsDefined(Regionality))
            {
                writer.WritePropertyName("regionality"u8);
                writer.WriteStringValue(Regionality.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExtensionOptions))
            {
                writer.WritePropertyName("extensionOptions"u8);
                writer.WriteObjectValue(ExtensionOptions);
            }
            if (Optional.IsDefined(MarketplaceType))
            {
                writer.WritePropertyName("marketplaceType"u8);
                writer.WriteStringValue(MarketplaceType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SwaggerSpecifications))
            {
                writer.WritePropertyName("swaggerSpecifications"u8);
                writer.WriteStartArray();
                foreach (var item in SwaggerSpecifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedUnauthorizedActions))
            {
                writer.WritePropertyName("allowedUnauthorizedActions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnauthorizedActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AuthorizationActionMappings))
            {
                writer.WritePropertyName("authorizationActionMappings"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationActionMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedAccessChecks))
            {
                writer.WritePropertyName("linkedAccessChecks"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedAccessChecks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultApiVersion))
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (Optional.IsCollectionDefined(LoggingRules))
            {
                writer.WritePropertyName("loggingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoggingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ThrottlingRules))
            {
                writer.WritePropertyName("throttlingRules"u8);
                writer.WriteStartArray();
                foreach (var item in ThrottlingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (Optional.IsDefined(EnableAsyncOperation))
            {
                writer.WritePropertyName("enableAsyncOperation"u8);
                writer.WriteBooleanValue(EnableAsyncOperation.Value);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(EnableThirdPartyS2S))
            {
                writer.WritePropertyName("enableThirdPartyS2S"u8);
                writer.WriteBooleanValue(EnableThirdPartyS2S.Value);
            }
            if (Optional.IsDefined(SubscriptionLifecycleNotificationSpecifications))
            {
                writer.WritePropertyName("subscriptionLifecycleNotificationSpecifications"u8);
                writer.WriteObjectValue(SubscriptionLifecycleNotificationSpecifications);
            }
            if (Optional.IsDefined(IsPureProxy))
            {
                writer.WritePropertyName("isPureProxy"u8);
                writer.WriteBooleanValue(IsPureProxy.Value);
            }
            if (Optional.IsDefined(IdentityManagement))
            {
                writer.WritePropertyName("identityManagement"u8);
                writer.WriteObjectValue(IdentityManagement);
            }
            if (Optional.IsDefined(CheckNameAvailabilitySpecifications))
            {
                writer.WritePropertyName("checkNameAvailabilitySpecifications"u8);
                writer.WriteObjectValue(CheckNameAvailabilitySpecifications);
            }
            if (Optional.IsCollectionDefined(DisallowedActionVerbs))
            {
                writer.WritePropertyName("disallowedActionVerbs"u8);
                writer.WriteStartArray();
                foreach (var item in DisallowedActionVerbs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceTreeInfos))
            {
                writer.WritePropertyName("serviceTreeInfos"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceTreeInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (Optional.IsCollectionDefined(SubscriptionStateRules))
            {
                writer.WritePropertyName("subscriptionStateRules"u8);
                writer.WriteStartArray();
                foreach (var item in SubscriptionStateRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TemplateDeploymentOptions))
            {
                writer.WritePropertyName("templateDeploymentOptions"u8);
                writer.WriteObjectValue(TemplateDeploymentOptions);
            }
            if (Optional.IsCollectionDefined(ExtendedLocations))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceMovePolicy))
            {
                writer.WritePropertyName("resourceMovePolicy"u8);
                writer.WriteObjectValue(ResourceMovePolicy);
            }
            if (Optional.IsDefined(ResourceDeletionPolicy))
            {
                writer.WritePropertyName("resourceDeletionPolicy"u8);
                writer.WriteStringValue(ResourceDeletionPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceConcurrencyControlOptions))
            {
                writer.WritePropertyName("resourceConcurrencyControlOptions"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceConcurrencyControlOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ResourceGraphConfiguration))
            {
                writer.WritePropertyName("resourceGraphConfiguration"u8);
                writer.WriteObjectValue(ResourceGraphConfiguration);
            }
            if (Optional.IsDefined(Management))
            {
                writer.WritePropertyName("management"u8);
                writer.WriteObjectValue(Management);
            }
            if (Optional.IsDefined(OpenApiConfiguration))
            {
                writer.WritePropertyName("openApiConfiguration"u8);
                writer.WriteObjectValue(OpenApiConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static ResourceTypeRegistrationProperties DeserializeResourceTypeRegistrationProperties(JsonElement element)
        {
            Optional<RoutingType> routingType = default;
            Optional<Regionality> regionality = default;
            Optional<IList<ResourceTypeEndpoint>> endpoints = default;
            Optional<ResourceTypeRegistrationPropertiesExtensionOptions> extensionOptions = default;
            Optional<ResourceTypeRegistrationPropertiesMarketplaceType> marketplaceType = default;
            Optional<IList<SwaggerSpecification>> swaggerSpecifications = default;
            Optional<IList<string>> allowedUnauthorizedActions = default;
            Optional<IList<AuthorizationActionMapping>> authorizationActionMappings = default;
            Optional<IList<LinkedAccessCheck>> linkedAccessChecks = default;
            Optional<string> defaultApiVersion = default;
            Optional<IList<LoggingRule>> loggingRules = default;
            Optional<IList<ThrottlingRule>> throttlingRules = default;
            Optional<IList<string>> requiredFeatures = default;
            Optional<ResourceTypeRegistrationPropertiesFeaturesRule> featuresRule = default;
            Optional<bool> enableAsyncOperation = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> enableThirdPartyS2S = default;
            Optional<ResourceTypeRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications> subscriptionLifecycleNotificationSpecifications = default;
            Optional<bool> isPureProxy = default;
            Optional<ResourceTypeRegistrationPropertiesIdentityManagement> identityManagement = default;
            Optional<ResourceTypeRegistrationPropertiesCheckNameAvailabilitySpecifications> checkNameAvailabilitySpecifications = default;
            Optional<IList<string>> disallowedActionVerbs = default;
            Optional<IList<ServiceTreeInfo>> serviceTreeInfos = default;
            Optional<ResourceTypeRegistrationPropertiesRequestHeaderOptions> requestHeaderOptions = default;
            Optional<IList<SubscriptionStateRule>> subscriptionStateRules = default;
            Optional<ResourceTypeRegistrationPropertiesTemplateDeploymentOptions> templateDeploymentOptions = default;
            Optional<IList<ExtendedLocationOptions>> extendedLocations = default;
            Optional<ResourceTypeRegistrationPropertiesResourceMovePolicy> resourceMovePolicy = default;
            Optional<ResourceDeletionPolicy> resourceDeletionPolicy = default;
            Optional<IDictionary<string, ResourceConcurrencyControlOption>> resourceConcurrencyControlOptions = default;
            Optional<ResourceTypeRegistrationPropertiesResourceGraphConfiguration> resourceGraphConfiguration = default;
            Optional<ResourceTypeRegistrationPropertiesManagement> management = default;
            Optional<OpenApiConfiguration> openApiConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routingType = new RoutingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("regionality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    regionality = new Regionality(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceTypeEndpoint> array = new List<ResourceTypeEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeEndpoint.DeserializeResourceTypeEndpoint(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("extensionOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extensionOptions = ResourceTypeRegistrationPropertiesExtensionOptions.DeserializeResourceTypeRegistrationPropertiesExtensionOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("marketplaceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    marketplaceType = new ResourceTypeRegistrationPropertiesMarketplaceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swaggerSpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SwaggerSpecification> array = new List<SwaggerSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SwaggerSpecification.DeserializeSwaggerSpecification(item));
                    }
                    swaggerSpecifications = array;
                    continue;
                }
                if (property.NameEquals("allowedUnauthorizedActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedUnauthorizedActions = array;
                    continue;
                }
                if (property.NameEquals("authorizationActionMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizationActionMapping> array = new List<AuthorizationActionMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationActionMapping.DeserializeAuthorizationActionMapping(item));
                    }
                    authorizationActionMappings = array;
                    continue;
                }
                if (property.NameEquals("linkedAccessChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LinkedAccessCheck> array = new List<LinkedAccessCheck>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedAccessCheck.DeserializeLinkedAccessCheck(item));
                    }
                    linkedAccessChecks = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LoggingRule> array = new List<LoggingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoggingRule.DeserializeLoggingRule(item));
                    }
                    loggingRules = array;
                    continue;
                }
                if (property.NameEquals("throttlingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ThrottlingRule> array = new List<ThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThrottlingRule.DeserializeThrottlingRule(item));
                    }
                    throttlingRules = array;
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    featuresRule = ResourceTypeRegistrationPropertiesFeaturesRule.DeserializeResourceTypeRegistrationPropertiesFeaturesRule(property.Value);
                    continue;
                }
                if (property.NameEquals("enableAsyncOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableAsyncOperation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableThirdPartyS2S"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableThirdPartyS2S = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionLifecycleNotificationSpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionLifecycleNotificationSpecifications = ResourceTypeRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications.DeserializeResourceTypeRegistrationPropertiesSubscriptionLifecycleNotificationSpecifications(property.Value);
                    continue;
                }
                if (property.NameEquals("isPureProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPureProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("identityManagement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identityManagement = ResourceTypeRegistrationPropertiesIdentityManagement.DeserializeResourceTypeRegistrationPropertiesIdentityManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("checkNameAvailabilitySpecifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    checkNameAvailabilitySpecifications = ResourceTypeRegistrationPropertiesCheckNameAvailabilitySpecifications.DeserializeResourceTypeRegistrationPropertiesCheckNameAvailabilitySpecifications(property.Value);
                    continue;
                }
                if (property.NameEquals("disallowedActionVerbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    disallowedActionVerbs = array;
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestHeaderOptions = ResourceTypeRegistrationPropertiesRequestHeaderOptions.DeserializeResourceTypeRegistrationPropertiesRequestHeaderOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("subscriptionStateRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubscriptionStateRule> array = new List<SubscriptionStateRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubscriptionStateRule.DeserializeSubscriptionStateRule(item));
                    }
                    subscriptionStateRules = array;
                    continue;
                }
                if (property.NameEquals("templateDeploymentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    templateDeploymentOptions = ResourceTypeRegistrationPropertiesTemplateDeploymentOptions.DeserializeResourceTypeRegistrationPropertiesTemplateDeploymentOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExtendedLocationOptions> array = new List<ExtendedLocationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtendedLocationOptions.DeserializeExtendedLocationOptions(item));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("resourceMovePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceMovePolicy = ResourceTypeRegistrationPropertiesResourceMovePolicy.DeserializeResourceTypeRegistrationPropertiesResourceMovePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceDeletionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceDeletionPolicy = new ResourceDeletionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceConcurrencyControlOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ResourceConcurrencyControlOption> dictionary = new Dictionary<string, ResourceConcurrencyControlOption>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ResourceConcurrencyControlOption.DeserializeResourceConcurrencyControlOption(property0.Value));
                    }
                    resourceConcurrencyControlOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("resourceGraphConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceGraphConfiguration = ResourceTypeRegistrationPropertiesResourceGraphConfiguration.DeserializeResourceTypeRegistrationPropertiesResourceGraphConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("management"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    management = ResourceTypeRegistrationPropertiesManagement.DeserializeResourceTypeRegistrationPropertiesManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("openApiConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    openApiConfiguration = OpenApiConfiguration.DeserializeOpenApiConfiguration(property.Value);
                    continue;
                }
            }
            return new ResourceTypeRegistrationProperties(Optional.ToNullable(routingType), Optional.ToNullable(regionality), Optional.ToList(endpoints), extensionOptions.Value, Optional.ToNullable(marketplaceType), Optional.ToList(swaggerSpecifications), Optional.ToList(allowedUnauthorizedActions), Optional.ToList(authorizationActionMappings), Optional.ToList(linkedAccessChecks), defaultApiVersion.Value, Optional.ToList(loggingRules), Optional.ToList(throttlingRules), Optional.ToList(requiredFeatures), featuresRule.Value, Optional.ToNullable(enableAsyncOperation), Optional.ToNullable(provisioningState), Optional.ToNullable(enableThirdPartyS2S), subscriptionLifecycleNotificationSpecifications.Value, Optional.ToNullable(isPureProxy), identityManagement.Value, checkNameAvailabilitySpecifications.Value, Optional.ToList(disallowedActionVerbs), Optional.ToList(serviceTreeInfos), requestHeaderOptions.Value, Optional.ToList(subscriptionStateRules), templateDeploymentOptions.Value, Optional.ToList(extendedLocations), resourceMovePolicy.Value, Optional.ToNullable(resourceDeletionPolicy), Optional.ToDictionary(resourceConcurrencyControlOptions), resourceGraphConfiguration.Value, management.Value, openApiConfiguration.Value);
        }
    }
}
