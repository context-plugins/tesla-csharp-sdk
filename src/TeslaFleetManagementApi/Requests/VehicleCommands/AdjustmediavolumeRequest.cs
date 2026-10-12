using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Adjustmediavolume operation.
/// </summary>
public sealed record AdjustmediavolumeRequest
{
    public required string VehicleTag { get; init; }

    public required AdjustVolumeRequest Body { get; init; }
}
