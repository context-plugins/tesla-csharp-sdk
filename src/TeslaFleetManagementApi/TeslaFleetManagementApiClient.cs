using System.Net.Http;
using TeslaFleetManagementApi.Api;
using TeslaFleetManagementApi.Core;
using TeslaFleetManagementApi.Core.Logging;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi;

/// <summary>
/// Unofficial OpenAPI specification for Tesla Fleet Management Charging endpoints.
/// </summary>
public sealed class TeslaFleetManagementApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public TeslaFleetManagementApiClient(HttpClient httpClient, TeslaFleetManagementApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "TeslaFleetManagementApiClient/1.0.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "TeslaFleetManagementApiClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options, _server, _rawClient, urlFactory);
    }

    /// <summary>
    /// Charging history, invoices, and session data
    /// </summary>
    public Charging Charging => field ??= new Charging(_rawClient, _server, _auth);

    /// <summary>
    /// Energy site and Powerwall endpoints
    /// </summary>
    public Energy Energy => field ??= new Energy(_rawClient, _server, _auth);

    /// <summary>
    /// Partner account and telemetry endpoints
    /// </summary>
    public Partner Partner => field ??= new Partner(_rawClient, _server, _auth);

    /// <summary>
    /// User account and settings endpoints
    /// </summary>
    public User User => field ??= new User(_rawClient, _server, _auth);

    /// <summary>
    /// Commands that control vehicle behavior
    /// </summary>
    public VehicleCommands VehicleCommands => field ??= new VehicleCommands(_rawClient, _server, _auth);

    public Vehicles Vehicles => field ??= new Vehicles(_rawClient, _server, _auth);
}
