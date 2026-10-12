namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Nextfavoritemediatrack operation.
/// </summary>
public sealed record NextfavoritemediatrackRequest
{
    public required string VehicleTag { get; init; }
}
