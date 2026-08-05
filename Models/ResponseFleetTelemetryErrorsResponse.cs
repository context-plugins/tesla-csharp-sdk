using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseFleetTelemetryErrorsResponse
{
    [JsonPropertyName("fleet_telemetry_errors")]
    public required IReadOnlyList<FleetTelemetryError> FleetTelemetryErrors { get; init; }
}
