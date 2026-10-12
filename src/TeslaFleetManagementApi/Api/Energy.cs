using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TeslaFleetManagementApi.Core;
using TeslaFleetManagementApi.Core.Authentication;
using TeslaFleetManagementApi.Core.ErrorResponse;
using TeslaFleetManagementApi.Core.Exceptions;
using TeslaFleetManagementApi.Core.Extensions;
using TeslaFleetManagementApi.Core.Models;
using TeslaFleetManagementApi.Core.Request;
using TeslaFleetManagementApi.Core.Response;
using TeslaFleetManagementApi.Models;
using TeslaFleetManagementApi.Requests.Energy;

namespace TeslaFleetManagementApi.Api;

/// <summary>
/// Energy site and Powerwall endpoints
/// </summary>
public sealed class Energy
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Energy(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// adjustSiteSBackupReserve
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BackupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<BackupResponse> AdjustSiteSBackupReserve(AdjustSiteSBackupReserveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/backup"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BackupResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// adjustSiteSOffGridVehicleChargingReserve
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> AdjustSiteSOffGridVehicleChargingReserve(AdjustSiteSOffGridVehicleChargingReserveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/off_grid_vehicle_charging_reserve"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// allowDisallowChargingFromTheGridAndExportingEnergyToTheGrid
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(AllowDisallowChargingFromTheGridAndExportingEnergyToTheGridRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/grid_import_export"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getBackupOrEnergyHistory
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalendarHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CalendarHistoryResponse> GetBackupOrEnergyHistory(GetBackupOrEnergyHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/calendar_history"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [
                new Param("kind", request.Kind),
                new Param("start_date", request.StartDate.ToIso8601()),
                new Param("end_date", request.EndDate.ToIso8601()),
                new Param("period", request.Period),
                new Param("time_zone", request.TimeZone),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CalendarHistoryResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getLiveSiteStatus
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LiveStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<LiveStatusResponse> GetLiveSiteStatus(GetLiveSiteStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/live_status"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LiveStatusResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSiteInformationAssetsSettingsFeatures
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SiteInfoResponse> GetSiteInformationAssetsSettingsFeatures(GetSiteInformationAssetsSettingsFeaturesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/site_info"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SiteInfoResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getUserProductsVehiclesEnergySites
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProductsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<ProductsResponse> GetUserProductsVehiclesEnergySites(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/products"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ProductsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getWallConnectorChargingHistory
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargeHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<ChargeHistoryResponse> GetWallConnectorChargingHistory(GetWallConnectorChargingHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/telemetry_history"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [
                new Param("kind", request.Kind),
                new Param("start_date", request.StartDate.ToIso8601()),
                new Param("end_date", request.EndDate.ToIso8601()),
                new Param("time_zone", request.TimeZone),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChargeHistoryResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// setSiteModeAutonomousOrSelfConsumption
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> SetSiteModeAutonomousOrSelfConsumption(SetSiteModeAutonomousOrSelfConsumptionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/operation"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// updateStormWatchParticipation
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> UpdateStormWatchParticipation(UpdateStormWatchParticipationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/storm_mode"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// updateTimeOfUseTouSettings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> UpdateTimeOfUseTouSettings(UpdateTimeOfUseTouSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/api/1/energy_sites/{energy_site_id}/time_of_use_settings"),
            [new TemplateParam("energy_site_id", request.EnergySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            cancellationToken);
}
