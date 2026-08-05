using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargingPeriod
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date_time")]
    public string? StartDateTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dimensions")]
    public IReadOnlyList<ChargingDimension>? Dimensions { get; init; }
}
