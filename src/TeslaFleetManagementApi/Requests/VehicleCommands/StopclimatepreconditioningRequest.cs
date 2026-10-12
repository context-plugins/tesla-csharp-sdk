namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Stopclimatepreconditioning operation.
/// </summary>
public sealed record StopclimatepreconditioningRequest
{
    public required string VehicleTag { get; init; }
}
