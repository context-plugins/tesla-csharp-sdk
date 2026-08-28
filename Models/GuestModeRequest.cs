using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record GuestModeRequest
{
    /// <summary>
    /// Enable or disable Guest Mode
    /// </summary>
    [JsonPropertyName("enable")]
    public required bool Enable { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
