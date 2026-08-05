using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record OffGridVehicleChargingReserveRequest
{
    [JsonPropertyName("off_grid_vehicle_charging_reserve_percent")]
    public required int OffGridVehicleChargingReservePercent { get; init; }
}
