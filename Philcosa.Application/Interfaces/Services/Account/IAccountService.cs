using Philcosa.Application.Interfaces.Common;
using Philcosa.Application.Requests.Identity;
using Philcosa.Shared.Wrapper;
using System.Threading.Tasks;

namespace Philcosa.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}