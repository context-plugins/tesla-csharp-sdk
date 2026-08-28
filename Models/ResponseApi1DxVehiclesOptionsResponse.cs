using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ResponseApi1DxVehiclesOptionsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("codes")]
    public IReadOnlyList<VehicleOption>? Codes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
