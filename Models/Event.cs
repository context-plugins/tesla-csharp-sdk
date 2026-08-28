using System;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Event
{
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    [JsonPropertyName("duration")]
    public required int Duration { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
