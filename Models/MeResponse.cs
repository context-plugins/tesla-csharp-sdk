using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record MeResponse
{
    [JsonPropertyName("response")]
    public required ResponseMeResponse Response { get; init; }
}
