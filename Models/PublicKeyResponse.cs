using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record PublicKeyResponse
{
    [JsonPropertyName("response")]
    public required ResponsePublicKeyResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
