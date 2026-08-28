using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ChargeDuration
{
    [JsonPropertyName("seconds")]
    public required int Seconds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
