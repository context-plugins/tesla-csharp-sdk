using System.Net.Http.Headers;

namespace TeslaFleetManagementApi.Core.Pagination.States;

internal interface IPageState<in TResponse, out TState>
{
    TState? Next(TResponse page, HttpResponseHeaders headers);
}
