using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Api1VehiclesResponseGetVehicle
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public VehicleBase? Response { get; init; }
}
