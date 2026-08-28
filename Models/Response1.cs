using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Response1
{
    [JsonPropertyName("fleet_telemetry_error_vins")]
    public required IReadOnlyList<string> FleetTelemetryErrorVins { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
