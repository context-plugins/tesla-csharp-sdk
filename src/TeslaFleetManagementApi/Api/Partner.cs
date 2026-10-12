using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TeslaFleetManagementApi.Core;
using TeslaFleetManagementApi.Core.Authentication;
using TeslaFleetManagementApi.Core.ErrorResponse;
using TeslaFleetManagementApi.Core.Exceptions;
using TeslaFleetManagementApi.Core.Models;
using TeslaFleetManagementApi.Core.Request;
using TeslaFleetManagementApi.Core.Response;
using TeslaFleetManagementApi.Models;
using TeslaFleetManagementApi.Requests.Partner;

namespace TeslaFleetManagementApi.Api;

/// <summary>
/// Partner account and telemetry endpoints
/// </summary>
public sealed class Partner
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Partner(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getPublicKeyForADomain
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicKeyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<PublicKeyResponse> GetPublicKeyForADomain(GetPublicKeyForADomainRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/partner_accounts/public_key"),
            [],
            [new Param("domain", request.Domain)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicKeyResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getRecentFleetTelemetryErrors
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FleetTelemetryErrorsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<FleetTelemetryErrorsResponse> GetRecentFleetTelemetryErrors(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/partner_accounts/fleet_telemetry_errors"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FleetTelemetryErrorsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getVinsWithFleetTelemetryErrors
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BackupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<BackupResponse> GetVinsWithFleetTelemetryErrors(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/partner_accounts/fleet_telemetry_error_vins"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BackupResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// registerAPartnerAccount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterPartnerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<RegisterPartnerResponse> RegisterAPartnerAccount(RegisterAPartnerAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/partner_accounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RegisterPartnerResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);
}
