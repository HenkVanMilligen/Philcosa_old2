using Philcosa.Application.Extensions;
using Philcosa.Application.Interfaces.Repositories;
using Philcosa.Application.Specifications;
using Philcosa.Domain.Entities;
using Philcosa.Shared.Wrapper;
using MediatR;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Philcosa.Application.Features.Covers.Queries.GetAllPaged
{
    //public class GetAllCountriesQuery : IRequest<PaginatedResult<GetAllPagedCountriesResponse>>
    //{
    //    public int PageNumber { get; set; }
    //    public int PageSize { get; set; }
    //    public string SearchString { get; set; }

    //    public GetAllCountriesQuery(int pageNumber, int pageSize, string searchString)
    //    {
    //        PageNumber = pageNumber;
    //        PageSize = pageSize;
    //        SearchString = searchString;
    //    }
    //}

    //public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, PaginatedResult<GetAllPagedCountriesResponse>>
    //{
    //    private readonly IUnitOfWork _unitOfWork;

    //    public GetAllCountriesQueryHandler(IUnitOfWork unitOfWork)
    //    {
    //        _unitOfWork = unitOfWork;
    //    }

    //    public async Task<PaginatedResult<GetAllPagedCountriesResponse>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
    //    {
    //        Expression<Func<Country, GetAllPagedCountriesResponse>> expression = e => new GetAllPagedCountriesResponse
    //        {
    //            Id = e.Id,
    //            Code = e.Code,
    //            Name = e.Name,
    //        };
    //        var countryFilterSpec = new ProductFilterSpecification(request.SearchString);
    //        var data = await _unitOfWork.Repository<Country>().Entities
    //           .Specify(countryFilterSpec)
    //           .Select(expression)
    //           .ToPaginatedListAsync(request.PageNumber, request.PageSize);
    //        return data;
    //    }
    //}
}