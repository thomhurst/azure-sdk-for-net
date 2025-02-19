// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(IotHubDeviceDisconnectedEventDataConverter))]
    public partial class IotHubDeviceDisconnectedEventData
    {
        internal static IotHubDeviceDisconnectedEventData DeserializeIotHubDeviceDisconnectedEventData(JsonElement element)
        {
            Optional<string> deviceId = default;
            Optional<string> moduleId = default;
            Optional<string> hubName = default;
            Optional<DeviceConnectionStateEventInfo> deviceConnectionStateEventInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionStateEventInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deviceConnectionStateEventInfo = DeviceConnectionStateEventInfo.DeserializeDeviceConnectionStateEventInfo(property.Value);
                    continue;
                }
            }
            return new IotHubDeviceDisconnectedEventData(deviceId.Value, moduleId.Value, hubName.Value, deviceConnectionStateEventInfo.Value);
        }

        internal partial class IotHubDeviceDisconnectedEventDataConverter : JsonConverter<IotHubDeviceDisconnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, IotHubDeviceDisconnectedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override IotHubDeviceDisconnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIotHubDeviceDisconnectedEventData(document.RootElement);
            }
        }
    }
}
