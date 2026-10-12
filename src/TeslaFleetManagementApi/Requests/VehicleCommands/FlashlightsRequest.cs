namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Flashlights operation.
/// </summary>
public sealed record FlashlightsRequest
{
    public required string VehicleTag { get; init; }
}
