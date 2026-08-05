using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargeDuration
{
    [JsonPropertyName("seconds")]
    public required int Seconds { get; init; }
}
