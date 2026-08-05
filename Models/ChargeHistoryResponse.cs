using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargeHistoryResponse
{
    [JsonPropertyName("response")]
    public required ResponseChargeHistoryResponse Response { get; init; }
}
