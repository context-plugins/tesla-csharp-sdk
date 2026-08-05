using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseOrdersResponse
{
    [JsonPropertyName("vehicleMapId")]
    public required int VehicleMapId { get; init; }

    [JsonPropertyName("referenceNumber")]
    public required string ReferenceNumber { get; init; }

    [JsonPropertyName("vin")]
    public required string Vin { get; init; }

    [JsonPropertyName("orderStatus")]
    public required string OrderStatus { get; init; }

    [JsonPropertyName("orderSubstatus")]
    public required string OrderSubstatus { get; init; }

    [JsonPropertyName("modelCode")]
    public required string ModelCode { get; init; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; init; }

    [JsonPropertyName("locale")]
    public required string Locale { get; init; }

    [JsonPropertyName("mktOptions")]
    public required string MktOptions { get; init; }

    [JsonPropertyName("isB2b")]
    public required bool IsB2B { get; init; }
}
