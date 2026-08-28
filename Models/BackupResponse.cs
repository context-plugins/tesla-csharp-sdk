using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record BackupResponse
{
    [JsonPropertyName("response")]
    public required ResponseModel Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
