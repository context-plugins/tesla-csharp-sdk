namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the RemoveDriverAccessFromAVehicle operation.
/// </summary>
public sealed record RemoveDriverAccessFromAVehicleRequest
{
    public required string VehicleTag { get; init; }
}
