using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record RegisterPartnerRequest
{
    [JsonPropertyName("domain")]
    public required string Domain { get; init; }
}
