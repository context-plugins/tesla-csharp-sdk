using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;
using TeslaFleetManagementApi.Models.Enums;

namespace TeslaFleetManagementApi.Models;

public record ActuateTrunkRequest
{
    [JsonPropertyName("which_trunk")]
    public required WhichTrunk WhichTrunk { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
