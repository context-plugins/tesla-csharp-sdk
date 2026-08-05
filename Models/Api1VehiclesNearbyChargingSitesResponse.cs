using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Api1VehiclesNearbyChargingSitesResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public Response3? Response { get; init; }
}
