using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record AdjustVolumeRequest
{
    [JsonPropertyName("volume")]
    public required int Volume { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
