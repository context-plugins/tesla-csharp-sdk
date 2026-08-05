using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseApi1DxVehiclesOptionsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("codes")]
    public IReadOnlyList<VehicleOption>? Codes { get; init; }
}
