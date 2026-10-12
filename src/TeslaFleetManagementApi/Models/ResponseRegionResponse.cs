using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record ResponseRegionResponse
{
    [JsonPropertyName("region")]
    public required string Region { get; init; }

    [JsonPropertyName("fleet_api_base_url")]
    public required string FleetApiBaseUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
