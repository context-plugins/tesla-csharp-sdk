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

namespace TeslaFleetManagementApi.Api;

/// <summary>
/// Commands that control vehicle behavior
/// </summary>
public sealed class VehicleCommands
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VehicleCommands(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Actuate trunk
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Controls the front or rear trunk
    /// </remarks>
    public Task<CommandResponse> Actuatetrunk(string vehicleTag,
        ActuateTrunkRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/actuate_trunk"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Add charge schedule
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Addchargeschedule(string vehicleTag,
        AddChargeScheduleRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/add_charge_schedule"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Add precondition schedule
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Addpreconditionschedule(string vehicleTag,
        AddPreconditionScheduleRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/add_precondition_schedule"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Adjust media volume
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Adjustmediavolume(string vehicleTag,
        AdjustVolumeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/adjust_volume"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel software update
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Cancelsoftwareupdate(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/cancel_software_update"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Charge max range
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Chargemaxrange(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/charge_max_range"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Charge standard
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Chargestandard(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/charge_standard"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Clear PIN to Drive (admin)
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deactivates PIN to Drive and resets the associated PIN for supported firmware versions.
    /// </remarks>
    public Task<CommandResponse> ClearPintoDriveAdmin(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/clear_pin_to_drive_admin"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Close charge port door
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Closechargeportdoor(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/charge_port_door_close"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Enable or disable Guest Mode
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> EnableordisableGuestMode(string vehicleTag,
        GuestModeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/guest_mode"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Erase user data
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Erases user data from the vehicle UI. Requires Guest Mode.
    /// </remarks>
    public Task<CommandResponse> Eraseuserdata(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/erase_user_data"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Flash lights
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Briefly flashes vehicle headlights.
    /// </remarks>
    public Task<CommandResponse> Flashlights(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/flash_lights"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Honk horn
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Honkhorn(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/honk_horn"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Lock doors
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Lockdoors(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/door_lock"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Next favorite media track
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Nextfavoritemediatrack(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/media_next_fav"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Open charge port door
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Openchargeportdoor(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/charge_port_door_open"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Start charging
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Startcharging(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/charge_start"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Start climate preconditioning
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Startclimatepreconditioning(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/auto_conditioning_start"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Stop charging
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Stopcharging(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/charge_stop"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Stop climate preconditioning
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Stopclimatepreconditioning(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/auto_conditioning_stop"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);

    /// <summary>
    /// Unlock doors
    /// </summary>
    /// <param name="vehicleTag"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CommandResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<CommandResponse> Unlockdoors(string vehicleTag,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/1/vehicles/{vehicle_tag}/command/door_unlock"),
            [new TemplateParam("vehicle_tag", vehicleTag)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CommandResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ThirdpartytokenAuthorizationCode, _auth.ThirdpartytokenClientCredentials)],
            requestOptions,
            ct);
}
