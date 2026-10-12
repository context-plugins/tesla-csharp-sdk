namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid operation.
/// </summary>
public sealed record AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest
{
    public required string EnergySiteId { get; init; }

    public object? Body { get; init; }
}
