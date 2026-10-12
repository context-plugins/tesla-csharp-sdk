namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetEligibleVehicleSubscriptions operation.
/// </summary>
public sealed record GetEligibleVehicleSubscriptionsRequest
{
    public required string Vin { get; init; }
}
