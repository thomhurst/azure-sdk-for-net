// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FileShareProtectableItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ParentContainerFabricId))
            {
                writer.WritePropertyName("parentContainerFabricId"u8);
                writer.WriteStringValue(ParentContainerFabricId);
            }
            if (Optional.IsDefined(ParentContainerFriendlyName))
            {
                writer.WritePropertyName("parentContainerFriendlyName"u8);
                writer.WriteStringValue(ParentContainerFriendlyName);
            }
            if (Optional.IsDefined(AzureFileShareType))
            {
                writer.WritePropertyName("azureFileShareType"u8);
                writer.WriteStringValue(AzureFileShareType.Value.ToString());
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static FileShareProtectableItem DeserializeFileShareProtectableItem(JsonElement element)
        {
            Optional<string> parentContainerFabricId = default;
            Optional<string> parentContainerFriendlyName = default;
            Optional<BackupFileShareType> azureFileShareType = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string protectableItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentContainerFabricId"u8))
                {
                    parentContainerFabricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentContainerFriendlyName"u8))
                {
                    parentContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileShareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureFileShareType = new BackupFileShareType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
            }
            return new FileShareProtectableItem(backupManagementType.Value, workloadType.Value, protectableItemType, friendlyName.Value, Optional.ToNullable(protectionState), parentContainerFabricId.Value, parentContainerFriendlyName.Value, Optional.ToNullable(azureFileShareType));
        }
    }
}
