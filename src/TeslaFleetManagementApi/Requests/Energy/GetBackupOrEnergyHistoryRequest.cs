using System;
using TeslaFleetManagementApi.Models.Enums;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the GetBackupOrEnergyHistory operation.
/// </summary>
public sealed record GetBackupOrEnergyHistoryRequest
{
    public required string EnergySiteId { get; init; }

    public required Kind Kind { get; init; }

    public required DateTimeOffset StartDate { get; init; }

    public required DateTimeOffset EndDate { get; init; }

    public string? Period { get; init; }

    public string? TimeZone { get; init; }
}
