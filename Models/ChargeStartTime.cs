using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargeStartTime
{
    [JsonPropertyName("seconds")]
    public required int Seconds { get; init; }
}
