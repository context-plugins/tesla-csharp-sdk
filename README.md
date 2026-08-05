# Tesla Fleet Management API

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Tesla Fleet Management API SDK for .NET provides access to the Tesla Fleet Management API REST APIs from .NET applications.

Unofficial OpenAPI specification for Tesla Fleet Management Charging endpoints.

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/TeslaFleetManagementApi.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [TeslaFleetManagementApiClientOptions](TeslaFleetManagementApiClientOptions.cs).

```csharp
services.AddTeslaFleetManagementApiClient(options =>
    {
        options.BearerAuth = "YOUR_BEARER_TOKEN";
        options.ThirdpartytokenClientCredentials =
            new OAuth2ClientCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
            };
        options.ThirdpartytokenAuthorizationCode =
            new OAuth2AuthorizationCodeCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                RedirectUri = "YOUR_REDIRECT_URI",
                PromptForAuthorizationCode = authUrl => Task.FromResult(""),
            };
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [TeslaFleetManagementApiClientOptions](TeslaFleetManagementApiClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new TeslaFleetManagementApiClientOptions
    {
        BearerAuth = "YOUR_BEARER_TOKEN",
        ThirdpartytokenClientCredentials = new OAuth2ClientCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            ClientSecret = "YOUR_CLIENT_SECRET",
        },
        ThirdpartytokenAuthorizationCode = new OAuth2AuthorizationCodeCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            RedirectUri = "YOUR_REDIRECT_URI",
            PromptForAuthorizationCode = authUrl => Task.FromResult(""),
        },
        Environment = ServerEnvironment.Production,
    };
var client = new TeslaFleetManagementApiClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `TeslaFleetManagementApiClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
