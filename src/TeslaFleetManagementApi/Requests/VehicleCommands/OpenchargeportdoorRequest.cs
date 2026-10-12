namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Openchargeportdoor operation.
/// </summary>
public sealed record OpenchargeportdoorRequest
{
    public required string VehicleTag { get; init; }
}
