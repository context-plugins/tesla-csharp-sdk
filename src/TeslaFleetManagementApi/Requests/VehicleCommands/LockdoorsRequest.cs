namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Lockdoors operation.
/// </summary>
public sealed record LockdoorsRequest
{
    public required string VehicleTag { get; init; }
}
