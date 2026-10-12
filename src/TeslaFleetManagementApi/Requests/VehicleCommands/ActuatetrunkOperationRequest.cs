using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Actuatetrunk operation.
/// </summary>
public sealed record ActuatetrunkOperationRequest
{
    public required string VehicleTag { get; init; }

    public required ActuateTrunkRequest Body { get; init; }
}
