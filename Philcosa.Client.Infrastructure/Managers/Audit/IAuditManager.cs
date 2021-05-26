using Philcosa.Application.Responses.Audit;
using Philcosa.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Philcosa.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<string> DownloadFileAsync();
    }
}