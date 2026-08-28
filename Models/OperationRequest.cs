using System.Text.Json.Serialization;
using Tesla.Core.Models;
using Tesla.Models.Enums;

namespace Tesla.Models;

public record OperationRequest
{
    [JsonPropertyName("default_real_mode")]
    public required DefaultRealMode DefaultRealMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
