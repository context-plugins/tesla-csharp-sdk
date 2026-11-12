using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using TeslaFleetManagementApi.Core.Hooks;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<HeaderParam>? Headers { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
