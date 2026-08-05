using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargingDimension
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume")]
    public double? Volume { get; init; }
}
