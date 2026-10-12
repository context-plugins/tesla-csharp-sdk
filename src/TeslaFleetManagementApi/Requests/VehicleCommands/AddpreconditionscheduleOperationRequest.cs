using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Addpreconditionschedule operation.
/// </summary>
public sealed record AddpreconditionscheduleOperationRequest
{
    public required string VehicleTag { get; init; }

    public required AddPreconditionScheduleRequest Body { get; init; }
}
