using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Response2
{
    [JsonPropertyName("signaling")]
    public required Signaling Signaling { get; init; }
}
