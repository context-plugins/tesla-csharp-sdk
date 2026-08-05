using System.Net.Http;

namespace TeslaFleetManagementApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}