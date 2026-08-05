using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record AddPreconditionScheduleRequest
{
    [JsonPropertyName("lat")]
    public required double Lat { get; init; }

    [JsonPropertyName("lon")]
    public required double Lon { get; init; }

    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("days_of_week")]
    public string? DaysOfWeek { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("precondition_time")]
    public int? PreconditionTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("one_time")]
    public bool? OneTime { get; init; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }
}
