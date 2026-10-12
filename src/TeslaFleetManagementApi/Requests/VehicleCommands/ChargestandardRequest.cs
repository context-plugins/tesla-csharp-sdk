namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Chargestandard operation.
/// </summary>
public sealed record ChargestandardRequest
{
    public required string VehicleTag { get; init; }
}
