using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Api1DxVehiclesOptionsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ResponseApi1DxVehiclesOptionsResponse? Response { get; init; }
}
