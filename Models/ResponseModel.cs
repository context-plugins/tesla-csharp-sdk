using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseModel
{
    [JsonPropertyName("code")]
    public required int Code { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
