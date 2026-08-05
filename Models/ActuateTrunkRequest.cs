using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Models.Enums;

namespace TeslaFleetManagementApi.Models;

public record ActuateTrunkRequest
{
    [JsonPropertyName("which_trunk")]
    public required WhichTrunk WhichTrunk { get; init; }
}
