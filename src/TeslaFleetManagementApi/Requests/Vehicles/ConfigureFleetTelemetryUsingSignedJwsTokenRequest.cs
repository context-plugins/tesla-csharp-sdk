using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the ConfigureFleetTelemetryUsingSignedJwsToken operation.
/// </summary>
public sealed record ConfigureFleetTelemetryUsingSignedJwsTokenRequest
{
    public required FleetTelemetryJwsRequest Body { get; init; }
}
