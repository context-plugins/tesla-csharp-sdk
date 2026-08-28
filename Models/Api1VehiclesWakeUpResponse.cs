using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Api1VehiclesWakeUpResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public VehicleBase? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
