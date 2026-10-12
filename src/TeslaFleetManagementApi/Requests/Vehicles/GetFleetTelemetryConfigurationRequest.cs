namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetFleetTelemetryConfiguration operation.
/// </summary>
public sealed record GetFleetTelemetryConfigurationRequest
{
    public required string VehicleTag { get; init; }
}
