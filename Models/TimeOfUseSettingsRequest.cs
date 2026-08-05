using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record TimeOfUseSettingsRequest
{
    [JsonPropertyName("tou_settings")]
    public required TouSettings TouSettings { get; init; }
}
