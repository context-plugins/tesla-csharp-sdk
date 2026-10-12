namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Cancelsoftwareupdate operation.
/// </summary>
public sealed record CancelsoftwareupdateRequest
{
    public required string VehicleTag { get; init; }
}
