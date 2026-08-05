using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Api1VehiclesWakeUpResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public VehicleBase? Response { get; init; }
}
