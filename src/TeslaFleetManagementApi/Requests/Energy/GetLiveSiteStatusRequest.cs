namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the GetLiveSiteStatus operation.
/// </summary>
public sealed record GetLiveSiteStatusRequest
{
    public required string EnergySiteId { get; init; }
}
