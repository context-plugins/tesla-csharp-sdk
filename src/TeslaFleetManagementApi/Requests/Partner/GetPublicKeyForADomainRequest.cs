namespace TeslaFleetManagementApi.Requests.Partner;

/// <summary>
/// The inputs of the GetPublicKeyForADomain operation.
/// </summary>
public sealed record GetPublicKeyForADomainRequest
{
    public required string Domain { get; init; }
}
