using Philcosa.Client.Infrastructure.Extensions;
using Philcosa.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using Philcosa.Application.Features.Dashboards.Queries.GetData;

namespace Philcosa.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}