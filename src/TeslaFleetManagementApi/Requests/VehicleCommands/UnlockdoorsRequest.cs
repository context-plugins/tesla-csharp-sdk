namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Unlockdoors operation.
/// </summary>
public sealed record UnlockdoorsRequest
{
    public required string VehicleTag { get; init; }
}
