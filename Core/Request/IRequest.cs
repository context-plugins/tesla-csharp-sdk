using System.Net.Http;

namespace Tesla.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}