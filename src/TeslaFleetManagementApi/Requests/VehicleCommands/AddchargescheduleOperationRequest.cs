using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Addchargeschedule operation.
/// </summary>
public sealed record AddchargescheduleOperationRequest
{
    public required string VehicleTag { get; init; }

    public required AddChargeScheduleRequest Body { get; init; }
}
