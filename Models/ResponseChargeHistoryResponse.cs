using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseChargeHistoryResponse
{
    [JsonPropertyName("charge_history")]
    public required IReadOnlyList<ChargeHistory> ChargeHistory { get; init; }
}
