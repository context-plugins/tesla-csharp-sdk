using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record FleetTelemetryErrorsResponse
{
    [JsonPropertyName("response")]
    public required ResponseFleetTelemetryErrorsResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
