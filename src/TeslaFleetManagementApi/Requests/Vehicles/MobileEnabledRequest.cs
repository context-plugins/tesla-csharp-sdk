namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the MobileEnabled operation.
/// </summary>
public sealed record MobileEnabledRequest
{
    public required string VehicleTag { get; init; }
}
