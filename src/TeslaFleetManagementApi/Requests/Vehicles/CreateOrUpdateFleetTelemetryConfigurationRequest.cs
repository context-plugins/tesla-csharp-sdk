namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the CreateOrUpdateFleetTelemetryConfiguration operation.
/// </summary>
public sealed record CreateOrUpdateFleetTelemetryConfigurationRequest
{
    public required object Body { get; init; }
}
