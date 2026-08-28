using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tesla.Core;
using Tesla.Core.Authentication;
using Tesla.Core.ErrorResponse;
using Tesla.Core.Exceptions;
using Tesla.Core.Models;
using Tesla.Core.Request;
using Tesla.Core.Response;
using Tesla.Models;

namespace Tesla.Api;

public sealed class Vehicles
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Vehicles(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// configureFleetTelemetryUsingSignedJwsToken
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> ConfigureFleetTelemetryUsingSignedJwsToken(FleetTelemetryJwsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/fleet_telemetry_config_jws"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// createOrUpdateFleetTelemetryConfiguration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> CreateOrUpdateFleetTelemetryConfiguration(object body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/fleet_telemetry_config"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// deleteFleetTelemetryConfiguration
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> DeleteFleetTelemetryConfiguration(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/fleet_telemetry_config"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getAllowedDriversForAVehicle
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DriversResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<DriversResponse> GetAllowedDriversForAVehicle(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/drivers"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DriversResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getEligibleVehicleSubscriptions
    /// </summary>
    /// <param name="vin"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SiteInfoResponse> GetEligibleVehicleSubscriptions(string vin,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/dx/vehicles/subscriptions/eligibility"),
            [],
            [new Param("vin", vin)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SiteInfoResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getEligibleVehicleUpgrades
    /// </summary>
    /// <param name="vin"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SiteInfoResponse> GetEligibleVehicleUpgrades(string vin,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/dx/vehicles/upgrades/eligibility"),
            [],
            [new Param("vin", vin)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SiteInfoResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getEnterpriseRolesForAVehicle
    /// </summary>
    /// <param name="vin"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> GetEnterpriseRolesForAVehicle(string vin,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/dx/enterprise/v1/{vin}/roles"),
            [new TemplateParam("vin", vin)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getFleetStatusForVehicles
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> GetFleetStatusForVehicles(FleetStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/fleet_status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getFleetTelemetryConfiguration
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> GetFleetTelemetryConfiguration(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/fleet_telemetry_config"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getFleetTelemetryErrorsForAVehicle
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<object> GetFleetTelemetryErrorsForAVehicle(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/fleet_telemetry_errors"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// getVehicle
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1VehiclesResponseResponse200"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1VehiclesResponseResponse200> GetVehicle(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Api1VehiclesResponseResponse200>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// listVehicles
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1VehiclesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1VehiclesResponse> ListVehicles(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Api1VehiclesResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// mobileEnabled
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1VehiclesMobileEnabledResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1VehiclesMobileEnabledResponse> MobileEnabled(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/mobile_enabled"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Api1VehiclesMobileEnabledResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// nearbyChargingSites
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1VehiclesNearbyChargingSitesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1VehiclesNearbyChargingSitesResponse> NearbyChargingSites(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/nearby_charging_sites"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Api1VehiclesNearbyChargingSitesResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// removeDriverAccessFromAVehicle
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SimpleOkResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SimpleOkResponse> RemoveDriverAccessFromAVehicle(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/drivers"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SimpleOkResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// setEnterprisePayerRoles
    /// </summary>
    /// <param name="vin"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task SetEnterprisePayerRoles(string vin,
        EnterprisePayerRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/dx/enterprise/v1/{vin}/payer"),
            [new TemplateParam("vin", vin)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// vehicleLiveData
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SiteInfoResponse> VehicleLiveData(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/vehicle_data"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
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
    /// vehicleOptions
    /// </summary>
    /// <param name="vin"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1DxVehiclesOptionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1DxVehiclesOptionsResponse> VehicleOptions(string vin,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/dx/vehicles/options"),
            [],
            [new Param("vin", vin)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Api1DxVehiclesOptionsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// vehicleSpecs
    /// </summary>
    /// <param name="vin"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SiteInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<SiteInfoResponse> VehicleSpecs(string vin,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vin}/specs"),
            [new TemplateParam("vin", vin)],
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
    /// wakeUpVehicle
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1VehiclesWakeUpResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1VehiclesWakeUpResponse> WakeUpVehicle(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/wake_up"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Api1VehiclesWakeUpResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// warrantyDetails
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Api1DxWarrantyDetailsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Api1DxWarrantyDetailsResponse> WarrantyDetails(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/dx/warranty/details"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Api1DxWarrantyDetailsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);
}
