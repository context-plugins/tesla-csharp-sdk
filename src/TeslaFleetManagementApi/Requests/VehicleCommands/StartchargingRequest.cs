namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Startcharging operation.
/// </summary>
public sealed record StartchargingRequest
{
    public required string VehicleTag { get; init; }
}
