using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record TouSettings
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tariff_content_v2")]
    public object? TariffContentV2 { get; init; }
}
