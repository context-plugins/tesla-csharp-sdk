using System.Net.Http;
using Tesla.Api;
using Tesla.Core;
using Tesla.Core.Logging;
using Tesla.Core.Models;

namespace Tesla;

/// <summary>
/// Unofficial OpenAPI specification for Tesla Fleet Management Charging endpoints.
/// </summary>
public sealed class TeslaClient
{
    public TeslaClient(HttpClient httpClient, TeslaClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "TeslaClient/1.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "TeslaClient");
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        var auth = new AuthSchemes(options, server, rawClient, urlFactory);
        Charging = new Charging(rawClient, server, auth);
        Energy = new Energy(rawClient, server, auth);
        Partner = new Partner(rawClient, server, auth);
        User = new User(rawClient, server, auth);
        VehicleCommands = new VehicleCommands(rawClient, server, auth);
        Vehicles = new Vehicles(rawClient, server, auth);
    }

    /// <summary>
    /// Charging history, invoices, and session data
    /// </summary>
    public Charging Charging { get; }

    /// <summary>
    /// Energy site and Powerwall endpoints
    /// </summary>
    public Energy Energy { get; }

    /// <summary>
    /// Partner account and telemetry endpoints
    /// </summary>
    public Partner Partner { get; }

    /// <summary>
    /// User account and settings endpoints
    /// </summary>
    public User User { get; }

    /// <summary>
    /// Commands that control vehicle behavior
    /// </summary>
    public VehicleCommands VehicleCommands { get; }

    public Vehicles Vehicles { get; }
}
