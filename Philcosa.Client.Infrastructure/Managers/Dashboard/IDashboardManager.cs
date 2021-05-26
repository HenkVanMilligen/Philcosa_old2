using Philcosa.Shared.Wrapper;
using System.Threading.Tasks;
using Philcosa.Application.Features.Dashboards.Queries.GetData;

namespace Philcosa.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}