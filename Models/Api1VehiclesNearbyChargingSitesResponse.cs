using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Api1VehiclesNearbyChargingSitesResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public Response3? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
