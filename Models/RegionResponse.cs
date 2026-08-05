using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record RegionResponse
{
    [JsonPropertyName("response")]
    public required ResponseRegionResponse Response { get; init; }
}
