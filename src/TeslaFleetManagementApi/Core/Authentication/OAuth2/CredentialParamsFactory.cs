using System.Collections.Generic;

namespace TeslaFleetManagementApi.Core.Authentication.OAuth2;

internal delegate IReadOnlyList<T> CredentialParamsFactory<out T>(string clientId, string? clientSecret);
