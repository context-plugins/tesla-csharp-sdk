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
using TeslaFleetManagementApi.Models.Enums;

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
    /// <param name="energySiteId"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BackupResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<BackupResponse> AdjustSiteSbackupReserve(string energySiteId,
        BackupRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/backup"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BackupResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// adjustSiteSOffGridVehicleChargingReserve
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> AdjustSiteSoffGridVehicleChargingReserve(string energySiteId,
        OffGridVehicleChargingReserveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/off_grid_vehicle_charging_reserve"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// allowDisallowChargingFromTheGridAndExportingEnergyToTheGrid
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> AllowDisallowChargingFromTheGridAndExportingEnergyToTheGrid(string energySiteId,
        object? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/grid_import_export"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getBackupOrEnergyHistory
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="kind"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="period"></param>
    /// <param name="timeZone"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalendarHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CalendarHistoryResponse> GetBackupOrEnergyHistory(string energySiteId,
        Kind kind,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        string? period,
        string? timeZone,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/calendar_history"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [new Param("kind", kind),
                new Param("start_date", startDate.ToIso8601()),
                new Param("end_date", endDate.ToIso8601()),
                new Param("period", period),
                new Param("time_zone", timeZone)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CalendarHistoryResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getLiveSiteStatus
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LiveStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<LiveStatusResponse> GetLiveSiteStatus(string energySiteId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/live_status"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LiveStatusResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getSiteInformationAssetsSettingsFeatures
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SiteInfoResponse> GetSiteInformationAssetsSettingsFeatures(string energySiteId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/site_info"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SiteInfoResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getUserProductsVehiclesEnergySites
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProductsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<ProductsResponse> GetUserProductsVehiclesEnergySites(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/products"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ProductsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getWallConnectorChargingHistory
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="kind"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="timeZone"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargeHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<ChargeHistoryResponse> GetWallConnectorChargingHistory(string energySiteId,
        KindGetWallConnectorChargingHistory kind,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        string? timeZone,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/telemetry_history"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [new Param("kind", kind),
                new Param("start_date", startDate.ToIso8601()),
                new Param("end_date", endDate.ToIso8601()),
                new Param("time_zone", timeZone)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChargeHistoryResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// setSiteModeAutonomousOrSelfConsumption
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> SetSiteModeAutonomousOrSelfConsumption(string energySiteId,
        OperationRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/operation"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// updateStormWatchParticipation
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> UpdateStormWatchParticipation(string energySiteId,
        StormModeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/storm_mode"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// updateTimeOfUseTouSettings
    /// </summary>
    /// <param name="energySiteId"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GenericUpdateResponse> UpdateTimeOfUseTouSettings(string energySiteId,
        TimeOfUseSettingsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/energy_sites/{energy_site_id}/time_of_use_settings"),
            [new TemplateParam("energy_site_id", energySiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericUpdateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);
}
