using TeslaFleetManagementApi.Core.Authentication.OAuth2;
using TeslaFleetManagementApi.Core.Authentication.OAuth2.AuthorizationCode;
using TeslaFleetManagementApi.Core.Authentication.OAuth2.ClientCredentials;
using TeslaFleetManagementApi.Core.Configuration;
using TeslaFleetManagementApi.Servers;

namespace TeslaFleetManagementApi;

public class TeslaFleetManagementApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public string? BearerAuth { get; set; }
    public OAuth2AuthorizationCodeCredentials? ThirdpartytokenAuthorizationCode { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? ThirdpartytokenAuthorizationCodeTokenStrategy { get; set; }
    public OAuth2ClientCredentials? ThirdpartytokenClientCredentials { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? ThirdpartytokenClientCredentialsTokenStrategy { get; set; }
}
