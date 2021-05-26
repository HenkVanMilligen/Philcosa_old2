using Philcosa.Application.Models.Chat;
using Philcosa.Application.Responses.Identity;
using Philcosa.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Philcosa.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}