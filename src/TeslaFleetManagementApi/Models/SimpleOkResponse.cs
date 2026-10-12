using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record SimpleOkResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public string? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
