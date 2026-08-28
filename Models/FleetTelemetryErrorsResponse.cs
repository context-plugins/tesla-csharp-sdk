using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record FleetTelemetryErrorsResponse
{
    [JsonPropertyName("response")]
    public required ResponseFleetTelemetryErrorsResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
