using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the EnableordisableGuestMode operation.
/// </summary>
public sealed record EnableordisableGuestModeRequest
{
    public required string VehicleTag { get; init; }

    public required GuestModeRequest Body { get; init; }
}
