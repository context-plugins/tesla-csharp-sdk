using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record FleetStatusRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vins")]
    public IReadOnlyList<string>? Vins { get; init; }
}
