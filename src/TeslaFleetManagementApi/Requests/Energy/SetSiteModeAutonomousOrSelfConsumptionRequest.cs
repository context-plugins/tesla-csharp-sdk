using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the SetSiteModeAutonomousOrSelfConsumption operation.
/// </summary>
public sealed record SetSiteModeAutonomousOrSelfConsumptionRequest
{
    public required string EnergySiteId { get; init; }

    public required OperationRequest Body { get; init; }
}
