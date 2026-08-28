using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record RegisterPartnerRequest
{
    [JsonPropertyName("domain")]
    public required string Domain { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
