namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Chargemaxrange operation.
/// </summary>
public sealed record ChargemaxrangeRequest
{
    public required string VehicleTag { get; init; }
}
