using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Response1
{
    [JsonPropertyName("fleet_telemetry_error_vins")]
    public required IReadOnlyList<string> FleetTelemetryErrorVins { get; init; }
}
