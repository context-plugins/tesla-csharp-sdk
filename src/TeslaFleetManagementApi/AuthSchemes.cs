using TeslaFleetManagementApi.Core;
using TeslaFleetManagementApi.Core.Authentication;
using TeslaFleetManagementApi.Core.Authentication.Bearer;
using TeslaFleetManagementApi.Core.Authentication.OAuth2;
using TeslaFleetManagementApi.Core.Authentication.OAuth2.AuthorizationCode;
using TeslaFleetManagementApi.Core.Authentication.OAuth2.ClientCredentials;

namespace TeslaFleetManagementApi;

internal sealed class AuthSchemes
{
    public IAuthScheme BearerAuth { get; }
    public IAuthScheme ThirdpartytokenClientCredentials { get; }
    public IAuthScheme ThirdpartytokenAuthorizationCode { get; }

    public AuthSchemes(TeslaFleetManagementApiClientOptions options,
        Server server,
        RawClient rawClient,
        UriFactory urlFactory)
    {
        BearerAuth = BearerAuthScheme.Create(options.BearerAuth);
        ThirdpartytokenClientCredentials =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(
                options.ThirdpartytokenClientCredentials,
                options.ThirdpartytokenClientCredentialsTokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForFormBodyRequest(server.Default("/token"), rawClient),
                options.TimeProvider);
        ThirdpartytokenAuthorizationCode =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(
                options.ThirdpartytokenAuthorizationCode,
                options.ThirdpartytokenAuthorizationCodeTokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForFormBodyRequest(
                        server.Default("/authorize"),
                        server.Default("/token"),
                        rawClient,
                        urlFactory),
                options.TimeProvider);
    }
}
