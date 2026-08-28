using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record TimeOfUseSettingsRequest
{
    [JsonPropertyName("tou_settings")]
    public required TouSettings TouSettings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
