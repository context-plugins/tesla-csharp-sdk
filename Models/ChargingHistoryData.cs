using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ChargingHistoryData
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<ChargingHistoryItem> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
