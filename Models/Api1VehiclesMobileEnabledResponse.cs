using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Api1VehiclesMobileEnabledResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public MobileEnabled? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
