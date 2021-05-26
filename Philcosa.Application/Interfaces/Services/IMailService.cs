using Philcosa.Application.Requests.Mail;
using System.Threading.Tasks;

namespace Philcosa.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}