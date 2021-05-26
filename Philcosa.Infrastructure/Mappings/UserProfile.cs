using AutoMapper;
using Philcosa.Application.Models.Identity;
using Philcosa.Application.Responses.Identity;

namespace Philcosa.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, ApplicationUser>().ReverseMap();
            CreateMap<ChatUserResponse, ApplicationUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}