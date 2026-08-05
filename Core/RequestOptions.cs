using Microsoft.Extensions.Logging;

namespace TeslaFleetManagementApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
