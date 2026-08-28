using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record TouSettings
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tariff_content_v2")]
    public object? TariffContentV2 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
