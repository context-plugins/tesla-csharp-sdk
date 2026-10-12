using System.Threading;
using System.Threading.Tasks;
using TeslaFleetManagementApi.Core.Models;

namespace TeslaFleetManagementApi.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}