using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record GenericUpdateResponse
{
    [JsonPropertyName("response")]
    public required ResponseModel Response { get; init; }
}
