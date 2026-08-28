using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Response2
{
    [JsonPropertyName("signaling")]
    public required Signaling Signaling { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
