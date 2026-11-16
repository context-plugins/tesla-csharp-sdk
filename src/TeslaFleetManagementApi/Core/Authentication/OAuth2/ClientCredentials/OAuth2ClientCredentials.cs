namespace TeslaFleetManagementApi.Core.Authentication.OAuth2.ClientCredentials;

public sealed class OAuth2ClientCredentials : IOAuth2Credentials
{
    public required string ClientId { get; init; }
    public required string ClientSecret { get; init; }
    /// <summary>Fleet API base URL of the region the token is for, e.g. <c>https://fleet-api.prd.na.vn.cloud.tesla.com</c>.</summary>
    public required string Audience { get; init; }
    public string? Scope { get; init; }
}

internal static class OAuth2ClientCredentialsExtensions
{
    extension(OAuth2ClientCredentials? credentials)
    {
        public OAuth2ClientCredentials? WithEnvironmentDefaults(string clientIdVariable, string clientSecretVariable, string audienceVariable, string scopeVariable)
        {
            if (credentials is not null)
                return credentials;

            return EnvironmentVariables.Get(clientIdVariable) is { } clientId && EnvironmentVariables.Get(clientSecretVariable) is { } clientSecret && EnvironmentVariables.Get(audienceVariable) is { } audience
                ? new OAuth2ClientCredentials { ClientId = clientId, ClientSecret = clientSecret, Audience = audience, Scope = EnvironmentVariables.Get(scopeVariable) }
                : null;
        }
    }
}
