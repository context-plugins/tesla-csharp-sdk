using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record BackupResponse
{
    [JsonPropertyName("response")]
    public required ResponseModel Response { get; init; }
}
