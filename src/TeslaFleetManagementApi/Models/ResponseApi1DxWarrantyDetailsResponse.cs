using System.Collections.Generic;
using System.Text.Json.Serialization;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Models;

public record ResponseApi1DxWarrantyDetailsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activeWarranty")]
    public IReadOnlyList<WarrantyItem>? ActiveWarranty { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upcomingWarranty")]
    public IReadOnlyList<WarrantyItem>? UpcomingWarranty { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiredWarranty")]
    public IReadOnlyList<WarrantyItem>? ExpiredWarranty { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
