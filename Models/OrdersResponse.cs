using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record OrdersResponse
{
    [JsonPropertyName("response")]
    public required IReadOnlyList<ResponseOrdersResponse> Response { get; init; }

    [JsonPropertyName("count")]
    public required int Count { get; init; }
}
