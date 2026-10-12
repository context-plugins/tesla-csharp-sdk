using System;
using TeslaFleetManagementApi.Models.Enums;

namespace TeslaFleetManagementApi.Requests.Energy;

/// <summary>
/// The inputs of the GetWallConnectorChargingHistory operation.
/// </summary>
public sealed record GetWallConnectorChargingHistoryRequest
{
    public required string EnergySiteId { get; init; }

    public required KindGetWallConnectorChargingHistory Kind { get; init; }

    public required DateTimeOffset StartDate { get; init; }

    public required DateTimeOffset EndDate { get; init; }

    public string? TimeZone { get; init; }
}
