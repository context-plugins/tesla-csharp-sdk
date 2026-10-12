using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the SetEnterprisePayerRoles operation.
/// </summary>
public sealed record SetEnterprisePayerRolesRequest
{
    public required string Vin { get; init; }

    public required EnterprisePayerRequest Body { get; init; }
}
