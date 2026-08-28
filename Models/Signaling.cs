using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Signaling
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    [JsonPropertyName("subscribe_connectivity")]
    public required bool SubscribeConnectivity { get; init; }

    [JsonPropertyName("use_auth_token")]
    public required bool UseAuthToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
