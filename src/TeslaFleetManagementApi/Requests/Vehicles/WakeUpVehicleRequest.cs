namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the WakeUpVehicle operation.
/// </summary>
public sealed record WakeUpVehicleRequest
{
    public required string VehicleTag { get; init; }
}
