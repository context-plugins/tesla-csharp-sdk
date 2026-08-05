using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record StormModeRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }
}
