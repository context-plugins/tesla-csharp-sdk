using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record RegisterPartnerResponse
{
    [JsonPropertyName("response")]
    public required ResponseRegisterPartnerResponse Response { get; init; }
}
