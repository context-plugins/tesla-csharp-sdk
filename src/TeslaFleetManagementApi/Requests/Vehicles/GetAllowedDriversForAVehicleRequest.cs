namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetAllowedDriversForAVehicle operation.
/// </summary>
public sealed record GetAllowedDriversForAVehicleRequest
{
    public required string VehicleTag { get; init; }
}
