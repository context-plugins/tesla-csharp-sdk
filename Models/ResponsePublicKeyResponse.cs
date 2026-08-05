using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponsePublicKeyResponse
{
    [JsonPropertyName("public_key")]
    public required string PublicKey { get; init; }
}
