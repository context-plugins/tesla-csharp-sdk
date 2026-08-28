using System.Text.Json.Serialization;
using Tesla.Core.Models;

namespace Tesla.Models;

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
