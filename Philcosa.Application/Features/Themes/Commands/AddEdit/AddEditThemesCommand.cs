using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Philcosa.Application.Interfaces.Repositories;
using Philcosa.Domain.Entities;
using Philcosa.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using Philcosa.Shared.Constants.Application;

namespace Philcosa.Application.Features.Themes.Commands.AddEdit
{
    public partial class AddEditThemesCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class AddEditThemesCommandHandler : IRequestHandler<AddEditThemesCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditThemesCommandHandler> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public AddEditThemesCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IStringLocalizer<AddEditThemesCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditThemesCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var theme = _mapper.Map<Theme>(command);
                await _unitOfWork.Repository<Theme>().AddAsync(theme);
                await _unitOfWork.ComitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllThemesCacheKey);
                return await Result<int>.SuccessAsync(theme.Id, _localizer["Theme Saved"]);
            }
            else
            {
                var theme = await _unitOfWork.Repository<Theme>().GetByIdAsync(command.Id);
                if (theme != null)
                {
                    theme.Name = command.Name ?? theme.Name;
                    await _unitOfWork.Repository<Theme>().UpdateAsync(theme);
                    await _unitOfWork.ComitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllThemesCacheKey);
                    return await Result<int>.SuccessAsync(theme.Id, _localizer["Theme Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Theme Not Found!"]);
                }
            }
        }
    }
}