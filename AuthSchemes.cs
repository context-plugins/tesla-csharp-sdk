using Tesla.Core;
using Tesla.Core.Authentication;
using Tesla.Core.Authentication.Bearer;
using Tesla.Core.Authentication.OAuth2;
using Tesla.Core.Authentication.OAuth2.AuthorizationCode;
using Tesla.Core.Authentication.OAuth2.ClientCredentials;

namespace Tesla;

internal sealed class AuthSchemes
{
    public IAuthScheme BearerAuth { get; }
    public IAuthScheme ThirdpartytokenClientCredentials { get; }
    public IAuthScheme ThirdpartytokenAuthorizationCode { get; }

    public AuthSchemes(TeslaClientOptions options, Server server, RawClient rawClient, UriFactory urlFactory)
    {
        BearerAuth = BearerAuthScheme.Create(options.BearerAuth);
        ThirdpartytokenClientCredentials =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.ThirdpartytokenClientCredentials,
                options.ThirdpartytokenClientCredentialsTokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForFormBodyRequest(server.Default("/token"), rawClient));
        ThirdpartytokenAuthorizationCode =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(options.ThirdpartytokenAuthorizationCode,
                options.ThirdpartytokenAuthorizationCodeTokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForFormBodyRequest(server.Default("/authorize"),
                        server.Default("/token"),
                        rawClient,
                        urlFactory));
    }
}
