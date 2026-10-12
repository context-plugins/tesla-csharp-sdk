namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Eraseuserdata operation.
/// </summary>
public sealed record EraseuserdataRequest
{
    public required string VehicleTag { get; init; }
}
