namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Closechargeportdoor operation.
/// </summary>
public sealed record ClosechargeportdoorRequest
{
    public required string VehicleTag { get; init; }
}
