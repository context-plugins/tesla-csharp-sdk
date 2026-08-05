using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record BackupRequest
{
    [JsonPropertyName("backup_reserve_percent")]
    public required int BackupReservePercent { get; init; }
}
