using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record AdjustVolumeRequest
{
    [JsonPropertyName("volume")]
    public required int Volume { get; init; }
}
