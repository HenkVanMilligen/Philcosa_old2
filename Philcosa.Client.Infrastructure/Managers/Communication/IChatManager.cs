using Philcosa.Application.Models.Chat;
using Philcosa.Application.Responses.Identity;
using Philcosa.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Philcosa.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}