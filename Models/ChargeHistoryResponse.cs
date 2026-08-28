using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ChargeHistoryResponse
{
    [JsonPropertyName("response")]
    public required ResponseChargeHistoryResponse Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
