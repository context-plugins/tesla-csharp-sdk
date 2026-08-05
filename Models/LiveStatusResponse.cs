using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record LiveStatusResponse
{
    [JsonPropertyName("response")]
    public required ResponseLiveStatusResponse Response { get; init; }
}
