using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record PublicKeyResponse
{
    [JsonPropertyName("response")]
    public required ResponsePublicKeyResponse Response { get; init; }
}
