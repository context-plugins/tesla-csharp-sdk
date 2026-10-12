using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the AdjustSiteSOffGridVehicleChargingReserve operation.
/// </summary>
public sealed record AdjustSiteSOffGridVehicleChargingReserveRequest
{
    public required string EnergySiteId { get; init; }

    public required OffGridVehicleChargingReserveRequest Body { get; init; }
}
