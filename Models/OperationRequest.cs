using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Models.Enums;

namespace TeslaFleetManagementApi.Models;

public record OperationRequest
{
    [JsonPropertyName("default_real_mode")]
    public required DefaultRealMode DefaultRealMode { get; init; }
}
