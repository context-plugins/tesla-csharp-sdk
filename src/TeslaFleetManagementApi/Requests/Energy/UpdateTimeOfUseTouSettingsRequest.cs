using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the UpdateTimeOfUseTouSettings operation.
/// </summary>
public sealed record UpdateTimeOfUseTouSettingsRequest
{
    public required string EnergySiteId { get; init; }

    public required TimeOfUseSettingsRequest Body { get; init; }
}
