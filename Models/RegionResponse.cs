using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record RegionResponse
{
    [JsonPropertyName("response")]
    public required ResponseRegionResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
