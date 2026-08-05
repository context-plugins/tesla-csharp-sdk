using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record GuestModeRequest
{
    /// <summary>
    /// Enable or disable Guest Mode
    /// </summary>
    [JsonPropertyName("enable")]
    public required bool Enable { get; init; }
}
