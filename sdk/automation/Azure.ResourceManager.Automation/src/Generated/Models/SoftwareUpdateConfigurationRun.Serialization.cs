// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationRun
    {
        internal static SoftwareUpdateConfigurationRun DeserializeSoftwareUpdateConfigurationRun(JsonElement element)
        {
            Optional<string> name = default;
            Optional<ResourceIdentifier> id = default;
            Optional<SoftwareUpdateConfigurationNavigation> softwareUpdateConfiguration = default;
            Optional<string> status = default;
            Optional<TimeSpan> configuredDuration = default;
            Optional<string> osType = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<int> computerCount = default;
            Optional<int> failedCount = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> createdBy = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> lastModifiedBy = default;
            Optional<SoftwareUpdateConfigurationRunTasks> tasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("softwareUpdateConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            softwareUpdateConfiguration = SoftwareUpdateConfigurationNavigation.DeserializeSoftwareUpdateConfigurationNavigation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configuredDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            configuredDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("computerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            computerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("failedCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            failedCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            createdBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tasks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tasks = SoftwareUpdateConfigurationRunTasks.DeserializeSoftwareUpdateConfigurationRunTasks(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SoftwareUpdateConfigurationRun(name.Value, id.Value, softwareUpdateConfiguration.Value, status.Value, Optional.ToNullable(configuredDuration), osType.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(computerCount), Optional.ToNullable(failedCount), Optional.ToNullable(creationTime), createdBy.Value, Optional.ToNullable(lastModifiedTime), lastModifiedBy.Value, tasks.Value);
        }
    }
}
