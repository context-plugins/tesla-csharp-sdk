namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetVehicle operation.
/// </summary>
public sealed record GetVehicleRequest
{
    public required string VehicleTag { get; init; }
}
