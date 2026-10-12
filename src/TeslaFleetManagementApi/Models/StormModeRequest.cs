using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record StormModeRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
