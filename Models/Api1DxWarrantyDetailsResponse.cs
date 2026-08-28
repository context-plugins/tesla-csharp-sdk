using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

public record Api1DxWarrantyDetailsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ResponseApi1DxWarrantyDetailsResponse? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
