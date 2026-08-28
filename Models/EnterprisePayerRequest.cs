using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record EnterprisePayerRequest
{
    [JsonPropertyName("role")]
    public required string Role { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("federation_id")]
    public string? FederationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_id")]
    public string? AccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
