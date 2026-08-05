using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record CommandResult
{
    [JsonPropertyName("result")]
    public required bool Result { get; init; }

    [JsonPropertyName("reason")]
    public required string Reason { get; init; }
}
