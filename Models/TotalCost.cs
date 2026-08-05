using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record TotalCost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excl_vat")]
    public double? ExclVat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("incl_vat")]
    public double? InclVat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vat")]
    public double? Vat { get; init; }
}
