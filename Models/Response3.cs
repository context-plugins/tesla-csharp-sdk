using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Response3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination_charging")]
    public IReadOnlyList<ChargingLocation>? DestinationCharging { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("superchargers")]
    public IReadOnlyList<ChargingLocation>? Superchargers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public int? Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
