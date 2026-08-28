using System.Collections.Generic;
using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ResponseCalendarHistoryResponse
{
    [JsonPropertyName("events")]
    public required IReadOnlyList<Event> Events { get; init; }

    [JsonPropertyName("total_events")]
    public required int TotalEvents { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
