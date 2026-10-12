namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the GetEnterpriseRolesForAVehicle operation.
/// </summary>
public sealed record GetEnterpriseRolesForAVehicleRequest
{
    public required string Vin { get; init; }
}
