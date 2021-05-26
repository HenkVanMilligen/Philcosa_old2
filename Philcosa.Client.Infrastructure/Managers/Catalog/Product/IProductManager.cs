using Philcosa.Application.Features.Products.Commands.AddEdit;
using Philcosa.Application.Features.Products.Queries.GetAllPaged;
using Philcosa.Application.Requests.Catalog;
using Philcosa.Shared.Wrapper;
using System.Threading.Tasks;

namespace Philcosa.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<string> ExportToExcelAsync();
    }
}