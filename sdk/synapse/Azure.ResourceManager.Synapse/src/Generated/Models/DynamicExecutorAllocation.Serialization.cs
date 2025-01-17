// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class DynamicExecutorAllocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(MinExecutors))
            {
                writer.WritePropertyName("minExecutors");
                writer.WriteNumberValue(MinExecutors.Value);
            }
            if (Optional.IsDefined(MaxExecutors))
            {
                writer.WritePropertyName("maxExecutors");
                writer.WriteNumberValue(MaxExecutors.Value);
            }
            writer.WriteEndObject();
        }

        internal static DynamicExecutorAllocation DeserializeDynamicExecutorAllocation(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<int> minExecutors = default;
            Optional<int> maxExecutors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minExecutors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minExecutors = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxExecutors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxExecutors = property.Value.GetInt32();
                    continue;
                }
            }
            return new DynamicExecutorAllocation(Optional.ToNullable(enabled), Optional.ToNullable(minExecutors), Optional.ToNullable(maxExecutors));
        }
    }
}
