using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record ChargeHistory
{
    [JsonPropertyName("charge_start_time")]
    public required ChargeStartTime ChargeStartTime { get; init; }

    [JsonPropertyName("charge_duration")]
    public required ChargeDuration ChargeDuration { get; init; }

    [JsonPropertyName("energy_added_wh")]
    public required int EnergyAddedWh { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
