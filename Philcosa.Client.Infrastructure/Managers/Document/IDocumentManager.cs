using Philcosa.Application.Features.Documents.Commands.AddEdit;
using Philcosa.Application.Features.Documents.Queries.GetAll;
using Philcosa.Application.Requests.Documents;
using Philcosa.Shared.Wrapper;
using System.Threading.Tasks;

namespace Philcosa.Client.Infrastructure.Managers.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}