using System;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseLiveStatusResponse
{
    [JsonPropertyName("solar_power")]
    public required double SolarPower { get; init; }

    [JsonPropertyName("energy_left")]
    public required double EnergyLeft { get; init; }

    [JsonPropertyName("total_pack_energy")]
    public required double TotalPackEnergy { get; init; }

    [JsonPropertyName("percentage_charged")]
    public required double PercentageCharged { get; init; }

    [JsonPropertyName("backup_capable")]
    public required bool BackupCapable { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("battery_power")]
    public double? BatteryPower { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("load_power")]
    public double? LoadPower { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grid_status")]
    public string? GridStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grid_power")]
    public double? GridPower { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("island_status")]
    public string? IslandStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storm_mode_active")]
    public bool? StormModeActive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }
}
