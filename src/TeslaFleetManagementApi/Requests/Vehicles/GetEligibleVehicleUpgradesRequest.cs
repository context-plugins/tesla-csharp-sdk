namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetEligibleVehicleUpgrades operation.
/// </summary>
public sealed record GetEligibleVehicleUpgradesRequest
{
    public required string Vin { get; init; }
}
