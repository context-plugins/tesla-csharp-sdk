using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record Api1DxWarrantyDetailsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ResponseApi1DxWarrantyDetailsResponse? Response { get; init; }
}
