using System;
using System.Collections.Generic;
using TeslaFleetManagementApi.Core.Authentication.OAuth2;
using TeslaFleetManagementApi.Core.Authentication.OAuth2.AuthorizationCode;
using TeslaFleetManagementApi.Core.Authentication.OAuth2.ClientCredentials;
using TeslaFleetManagementApi.Core.Configuration;
using TeslaFleetManagementApi.Core.Hooks;
using TeslaFleetManagementApi.Servers;

namespace TeslaFleetManagementApi;

public class TeslaFleetManagementApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? BearerAuth { get; set; }
    public OAuth2AuthorizationCodeCredentials? ThirdpartytokenAuthorizationCode { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? ThirdpartytokenAuthorizationCodeTokenStrategy { get; set; }
    public OAuth2ClientCredentials? ThirdpartytokenClientCredentials { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? ThirdpartytokenClientCredentialsTokenStrategy { get; set; }
}
