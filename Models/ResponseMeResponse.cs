using System;
using System.Text.Json.Serialization;

namespace TeslaFleetManagementApi.Models;

public record ResponseMeResponse
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("full_name")]
    public required string FullName { get; init; }

    [JsonPropertyName("profile_image_url")]
    public required string ProfileImageUrl { get; init; }

    [JsonPropertyName("vault_uuid")]
    public required Guid VaultUuid { get; init; }
}
