using AutoMapper;
using Philcosa.Application.Models.Audit;
using Philcosa.Application.Responses.Audit;

namespace Philcosa.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}