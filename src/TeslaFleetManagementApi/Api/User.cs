using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TeslaFleetManagementApi.Core;
using TeslaFleetManagementApi.Core.Authentication;
using TeslaFleetManagementApi.Core.ErrorResponse;
using TeslaFleetManagementApi.Core.Exceptions;
using TeslaFleetManagementApi.Core.Request;
using TeslaFleetManagementApi.Core.Response;
using TeslaFleetManagementApi.Models;

namespace TeslaFleetManagementApi.Api;

/// <summary>
/// User account and settings endpoints
/// </summary>
public sealed class User
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal User(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getActiveOrdersForAUser
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<OrdersResponse> GetActiveOrdersForAUser(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/users/orders"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrdersResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(
                _auth.ThirdpartytokenAuthorizationCode,
                _auth.ThirdpartytokenClientCredentials.ForScopes(
                    "openid",
                    "offline_access",
                    "user_data",
                    "vehicle_device_data",
                    "vehicle_location",
                    "vehicle_cmds",
                    "vehicle_charging_cmds",
                    "vehicle_specs",
                    "energy_device_data",
                    "energy_cmds",
                    "enterprise_management")),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getCustomFeatureFlagsForAUser
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BackupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<BackupResponse> GetCustomFeatureFlagsForAUser(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/users/feature_config"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BackupResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(
                _auth.ThirdpartytokenAuthorizationCode,
                _auth.ThirdpartytokenClientCredentials.ForScopes(
                    "openid",
                    "offline_access",
                    "user_data",
                    "vehicle_device_data",
                    "vehicle_location",
                    "vehicle_cmds",
                    "vehicle_charging_cmds",
                    "vehicle_specs",
                    "energy_device_data",
                    "energy_cmds",
                    "enterprise_management")),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSummaryOfAUserSAccount
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<MeResponse> GetSummaryOfAUserSAccount(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/users/me"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MeResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(
                _auth.ThirdpartytokenAuthorizationCode,
                _auth.ThirdpartytokenClientCredentials.ForScopes(
                    "openid",
                    "offline_access",
                    "user_data",
                    "vehicle_device_data",
                    "vehicle_location",
                    "vehicle_cmds",
                    "vehicle_charging_cmds",
                    "vehicle_specs",
                    "energy_device_data",
                    "energy_cmds",
                    "enterprise_management")),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getUserSRegionAndFleetApiBaseUrl
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<RegionResponse> GetUserSRegionAndFleetApiBaseUrl(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/users/region"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RegionResponse>(),
            RawErrorResponse.Instance,
            AuthScheme.Any(
                _auth.ThirdpartytokenAuthorizationCode,
                _auth.ThirdpartytokenClientCredentials.ForScopes(
                    "openid",
                    "offline_access",
                    "user_data",
                    "vehicle_device_data",
                    "vehicle_location",
                    "vehicle_cmds",
                    "vehicle_charging_cmds",
                    "vehicle_specs",
                    "energy_device_data",
                    "energy_cmds",
                    "enterprise_management")),
            requestOptions,
            cancellationToken);
}
