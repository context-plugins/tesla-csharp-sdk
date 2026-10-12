using System.Collections.Generic;
using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record FleetStatusRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vins")]
    public IReadOnlyList<string>? Vins { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
