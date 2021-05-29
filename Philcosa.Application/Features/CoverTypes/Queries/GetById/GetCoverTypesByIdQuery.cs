using AutoMapper;
using Philcosa.Application.Interfaces.Repositories;
using Philcosa.Domain.Entities;
using Philcosa.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Philcosa.Application.Features.CoverTypes.Queries.GetById
{
    public class GetCoverTypesByIdQuery : IRequest<Result<GetCoverTypesByIdResponse>>
    {
        public int Id { get; set; }
    }

    public class GetCoverTypesByIdQueryHandler : IRequestHandler<GetCoverTypesByIdQuery, Result<GetCoverTypesByIdResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCoverTypesByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetCoverTypesByIdResponse>> Handle(GetCoverTypesByIdQuery query, CancellationToken cancellationToken)
        {
            var coverType = await _unitOfWork.Repository<CoverType>().GetByIdAsync(query.Id);
            var mappedCoverType = new GetCoverTypesByIdResponse
            {
                Id = coverType.Id,
                Code = coverType.Code,
                Name = coverType.Name
            };
            return await Result<GetCoverTypesByIdResponse>.SuccessAsync(mappedCoverType);
        }
    }
}