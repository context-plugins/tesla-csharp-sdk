using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseCalendarHistoryResponse
{
    [JsonPropertyName("events")]
    public required IReadOnlyList<Event> Events { get; init; }

    [JsonPropertyName("total_events")]
    public required int TotalEvents { get; init; }
}
