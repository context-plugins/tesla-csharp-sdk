namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the DeleteFleetTelemetryConfiguration operation.
/// </summary>
public sealed record DeleteFleetTelemetryConfigurationRequest
{
    public required string VehicleTag { get; init; }
}
