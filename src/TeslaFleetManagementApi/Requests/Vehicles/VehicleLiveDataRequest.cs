namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the VehicleLiveData operation.
/// </summary>
public sealed record VehicleLiveDataRequest
{
    public required string VehicleTag { get; init; }
}
