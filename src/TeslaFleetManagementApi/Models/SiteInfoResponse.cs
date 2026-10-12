using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record SiteInfoResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public object? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
