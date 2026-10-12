using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetFleetStatusForVehicles operation.
/// </summary>
public sealed record GetFleetStatusForVehiclesRequest
{
    public required FleetStatusRequest Body { get; init; }
}
