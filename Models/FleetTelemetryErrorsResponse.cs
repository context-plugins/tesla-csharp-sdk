using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record FleetTelemetryErrorsResponse
{
    [JsonPropertyName("response")]
    public required ResponseFleetTelemetryErrorsResponse Response { get; init; }
}
