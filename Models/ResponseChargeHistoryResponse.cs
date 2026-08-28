using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ResponseChargeHistoryResponse
{
    [JsonPropertyName("charge_history")]
    public required IReadOnlyList<ChargeHistory> ChargeHistory { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
