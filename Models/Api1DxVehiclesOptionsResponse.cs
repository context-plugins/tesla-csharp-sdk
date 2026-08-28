using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Api1DxVehiclesOptionsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ResponseApi1DxVehiclesOptionsResponse? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
