using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record CommandResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public CommandResult? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
