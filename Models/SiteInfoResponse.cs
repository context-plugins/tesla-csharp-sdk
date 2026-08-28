using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record SiteInfoResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public object? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
