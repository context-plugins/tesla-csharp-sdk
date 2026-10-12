namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Stopcharging operation.
/// </summary>
public sealed record StopchargingRequest
{
    public required string VehicleTag { get; init; }
}
