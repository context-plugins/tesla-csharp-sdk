using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record MeResponse
{
    [JsonPropertyName("response")]
    public required ResponseMeResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
