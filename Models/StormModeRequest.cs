using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record StormModeRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
