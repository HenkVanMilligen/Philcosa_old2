using AutoMapper;
using Philcosa.Application.Features.Documents.Commands.AddEdit;
using Philcosa.Domain.Entities;

namespace Philcosa.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
        }
    }
}