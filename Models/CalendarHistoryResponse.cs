using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record CalendarHistoryResponse
{
    [JsonPropertyName("response")]
    public required ResponseCalendarHistoryResponse Response { get; init; }
}
