using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ChargingInvoice
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileName")]
    public string? FileName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contentId")]
    public string? ContentId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceType")]
    public string? InvoiceType { get; init; }
}
