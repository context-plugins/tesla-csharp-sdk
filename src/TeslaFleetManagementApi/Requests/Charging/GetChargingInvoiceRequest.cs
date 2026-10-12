namespace TeslaFleetManagementApi.Requests.Charging;

/// <summary>
/// The inputs of the GetChargingInvoice operation.
/// </summary>
public sealed record GetChargingInvoiceRequest
{
    /// <summary>
    /// Charging session invoice identifier
    /// </summary>
    public required string Id { get; init; }
}
