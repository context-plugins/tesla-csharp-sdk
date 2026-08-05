using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Location1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat")]
    public double? Lat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("long")]
    public double? Long { get; init; }
}
