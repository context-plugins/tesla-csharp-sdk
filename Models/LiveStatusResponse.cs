using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record LiveStatusResponse
{
    [JsonPropertyName("response")]
    public required ResponseLiveStatusResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
