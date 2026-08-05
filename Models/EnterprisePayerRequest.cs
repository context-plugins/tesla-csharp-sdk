using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

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
}
