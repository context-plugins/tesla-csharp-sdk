using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the UpdateStormWatchParticipation operation.
/// </summary>
public sealed record UpdateStormWatchParticipationRequest
{
    public required string EnergySiteId { get; init; }

    public required StormModeRequest Body { get; init; }
}
