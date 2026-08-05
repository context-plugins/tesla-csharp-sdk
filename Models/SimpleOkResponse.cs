using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record SimpleOkResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public string? Response { get; init; }
}
