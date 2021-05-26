using Philcosa.Application.Features.Brands.Queries.GetAll;
using Philcosa.Client.Infrastructure.Extensions;
using Philcosa.Shared.Wrapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Philcosa.Application.Features.Brands.Commands.AddEdit;

namespace Philcosa.Client.Infrastructure.Managers.Catalog.Brand
{
    public class BrandManager : IBrandManager
    {
        private readonly HttpClient _httpClient;

        public BrandManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.BrandsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.BrandsEndpoints.GetAll);
            return await response.ToResult<List<GetAllBrandsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditBrandCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.BrandsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}