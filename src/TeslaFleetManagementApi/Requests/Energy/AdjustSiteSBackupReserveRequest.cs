using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the AdjustSiteSBackupReserve operation.
/// </summary>
public sealed record AdjustSiteSBackupReserveRequest
{
    public required string EnergySiteId { get; init; }

    public required BackupRequest Body { get; init; }
}
