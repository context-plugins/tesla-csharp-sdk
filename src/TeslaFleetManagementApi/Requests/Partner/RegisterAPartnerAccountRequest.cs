using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Partner;

/// <summary>
/// The inputs of the RegisterAPartnerAccount operation.
/// </summary>
public sealed record RegisterAPartnerAccountRequest
{
    public required RegisterPartnerRequest Body { get; init; }
}
