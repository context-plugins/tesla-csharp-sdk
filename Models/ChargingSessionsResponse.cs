using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargingSessionsResponse
{
    [JsonPropertyName("response")]
    public required ChargingSessionsData Response { get; init; }
}
