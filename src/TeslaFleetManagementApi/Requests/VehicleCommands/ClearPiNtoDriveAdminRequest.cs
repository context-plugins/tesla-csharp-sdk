namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the ClearPiNtoDriveAdmin operation.
/// </summary>
public sealed record ClearPiNtoDriveAdminRequest
{
    public required string VehicleTag { get; init; }
}
