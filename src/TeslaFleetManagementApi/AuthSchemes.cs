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
    public IAuthScheme ThirdpartytokenAuthorizationCode { get; }
    public IAuthScheme ThirdpartytokenClientCredentials { get; }

    public AuthSchemes(TeslaFleetManagementApiClientOptions options,
        Server server,
        RawClient rawClient,
        UriFactory urlFactory)
    {
        BearerAuth =
            BearerAuthScheme.Create(
                "BearerAuth",
                options.BearerAuthProvider,
                options.BearerAuth ?? EnvironmentVariables.Get("TESLA_FLEET_MANAGEMENT_API_BEARER_AUTH"));
        ThirdpartytokenAuthorizationCode =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(
                "ThirdpartytokenAuthorizationCode",
                options.ThirdpartytokenAuthorizationCode,
                OAuth2AuthorizationCodeStrategy.ForFormBodyRequest(
                    server.AuthServer("/authorize"),
                    server.AccessTokenServer("/token"),
                    rawClient,
                    urlFactory),
                options.TimeProvider,
                scope: "openid offline_access user_data vehicle_device_data vehicle_location vehicle_cmds vehicle_charging_cmds vehicle_specs energy_device_data energy_cmds enterprise_management");
        ThirdpartytokenClientCredentials =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(
                "ThirdpartytokenClientCredentials",
                options.ThirdpartytokenClientCredentials.WithEnvironmentDefaults(
                    "TESLA_FLEET_MANAGEMENT_API_THIRDPARTYTOKEN_CLIENT_CREDENTIALS_CLIENT_ID",
                    "TESLA_FLEET_MANAGEMENT_API_THIRDPARTYTOKEN_CLIENT_CREDENTIALS_CLIENT_SECRET",
                    "TESLA_FLEET_MANAGEMENT_API_THIRDPARTYTOKEN_CLIENT_CREDENTIALS_AUDIENCE",
                    "TESLA_FLEET_MANAGEMENT_API_THIRDPARTYTOKEN_CLIENT_CREDENTIALS_SCOPE"),
                OAuth2ClientCredentialsStrategy.ForFormBodyRequest(server.AccessTokenServer("/token"), rawClient),
                options.TimeProvider);
    }
}
