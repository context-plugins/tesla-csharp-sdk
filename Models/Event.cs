using System;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Event
{
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    [JsonPropertyName("duration")]
    public required int Duration { get; init; }
}
