using System.Text.Json.Serialization;
using Tesla.Core.Models;
using Tesla.Models.Enums;

namespace Tesla.Models;

public record ActuateTrunkRequest
{
    [JsonPropertyName("which_trunk")]
    public required WhichTrunk WhichTrunk { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
