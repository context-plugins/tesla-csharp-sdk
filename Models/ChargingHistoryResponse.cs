using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargingHistoryResponse
{
    [JsonPropertyName("response")]
    public required ChargingHistoryData Response { get; init; }
}
