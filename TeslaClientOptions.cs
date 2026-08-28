using System.Collections.Generic;
using Tesla.Core.Authentication.OAuth2;
using Tesla.Core.Authentication.OAuth2.AuthorizationCode;
using Tesla.Core.Authentication.OAuth2.ClientCredentials;
using Tesla.Core.Configuration;
using Tesla.Core.Hooks;
using Tesla.Servers;

namespace Tesla;

public class TeslaClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? BearerAuth { get; set; }
    public OAuth2AuthorizationCodeCredentials? ThirdpartytokenAuthorizationCode { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? ThirdpartytokenAuthorizationCodeTokenStrategy { get; set; }
    public OAuth2ClientCredentials? ThirdpartytokenClientCredentials { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? ThirdpartytokenClientCredentialsTokenStrategy { get; set; }
}
