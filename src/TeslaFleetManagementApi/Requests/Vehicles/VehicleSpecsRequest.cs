namespace TeslaFleetManagementApi.Requests.Vehicles;

/// <summary>
/// The inputs of the VehicleSpecs operation.
/// </summary>
public sealed record VehicleSpecsRequest
{
    public required string Vin { get; init; }
}
