namespace TeslaFleetManagementApi.Requests.VehicleCommands;

/// <summary>
/// The inputs of the Honkhorn operation.
/// </summary>
public sealed record HonkhornRequest
{
    public required string VehicleTag { get; init; }
}
