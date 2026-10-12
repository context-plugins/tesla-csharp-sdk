namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the GetSiteInformationAssetsSettingsFeatures operation.
/// </summary>
public sealed record GetSiteInformationAssetsSettingsFeaturesRequest
{
    public required string EnergySiteId { get; init; }
}
