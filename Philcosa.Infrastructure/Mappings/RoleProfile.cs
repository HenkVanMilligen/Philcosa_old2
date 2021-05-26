using AutoMapper;
using Philcosa.Application.Responses.Identity;
using Microsoft.AspNetCore.Identity;

namespace Philcosa.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, IdentityRole>().ReverseMap();
        }
    }
}