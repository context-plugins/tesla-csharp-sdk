namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Startclimatepreconditioning operation.
/// </summary>
public sealed record StartclimatepreconditioningRequest
{
    public required string VehicleTag { get; init; }
}
