using Philcosa.Application.Responses.Audit;
using Philcosa.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Philcosa.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<string> ExportToExcelAsync(string userId);
    }
}