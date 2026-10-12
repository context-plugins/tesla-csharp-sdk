namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetFleetTelemetryErrorsForAVehicle operation.
/// </summary>
public sealed record GetFleetTelemetryErrorsForAVehicleRequest
{
    public required string VehicleTag { get; init; }
}
