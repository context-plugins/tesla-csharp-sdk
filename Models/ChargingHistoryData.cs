using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargingHistoryData
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<ChargingHistoryItem> Data { get; init; }
}
