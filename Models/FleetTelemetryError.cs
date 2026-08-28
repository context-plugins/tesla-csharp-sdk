using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record FleetTelemetryError
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("vin")]
    public required string Vin { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
