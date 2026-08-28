using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record RegisterPartnerResponse
{
    [JsonPropertyName("response")]
    public required ResponseRegisterPartnerResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
