namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the VehicleOptions operation.
/// </summary>
public sealed record VehicleOptionsRequest
{
    public required string Vin { get; init; }
}
