using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record SiteInfoResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public object? Response { get; init; }
}
