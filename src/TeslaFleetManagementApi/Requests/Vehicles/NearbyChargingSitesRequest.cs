namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the NearbyChargingSites operation.
/// </summary>
public sealed record NearbyChargingSitesRequest
{
    public required string VehicleTag { get; init; }
}
