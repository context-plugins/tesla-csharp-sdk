using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseRegionResponse
{
    [JsonPropertyName("region")]
    public required string Region { get; init; }

    [JsonPropertyName("fleet_api_base_url")]
    public required string FleetApiBaseUrl { get; init; }
}
