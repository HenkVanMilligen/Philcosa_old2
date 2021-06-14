using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Philcosa.Application.Interfaces.Repositories;
using Philcosa.Application.Interfaces.Services;
using Philcosa.Application.Requests;
using Philcosa.Domain.Entities;
using Philcosa.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using System;

namespace Philcosa.Application.Features.Covers.Commands.AddEdit
{
    public partial class AddEditCoverCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public DateTime CoverDate { get; set; }
        public string CoverIssuer { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string AmountIssued { get; set; }
        public string Atlas { get; set; }
        public string Alberta { get; set; }
        public string CoverType { get; set; }
        public int? CoverTypeId { get; set; }
        public string CoverValue { get; set; }
        public int CoverValueId { get; set; }
        public string Country { get; set; }
        public int CountryId { get; set; }
        public string ImageDataURL { get; set; }
        public string Theme1 { get; set; }
        public string Theme2 { get; set; }
        public string Theme3 { get; set; }
        public string Theme4 { get; set; }
        public UploadRequest UploadRequest { get; set; }
    }

    public class AddEditCoverCommandHandler : IRequestHandler<AddEditCoverCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUploadService _uploadService;
        private readonly IStringLocalizer<AddEditCoverCommandHandler> _localizer;

        public AddEditCoverCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUploadService uploadService, IStringLocalizer<AddEditCoverCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _uploadService = uploadService;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditCoverCommand command, CancellationToken cancellationToken)
        {
            var uploadRequest = command.UploadRequest;
            if (uploadRequest != null)
            {
                uploadRequest.FileName = $"C-{command.Country}-{command.CoverDate.ToShortDateString()}.{command.Number}{uploadRequest.Extension}";
            }

            if (command.Id == 0)
            {
                var cover = _mapper.Map<Cover>(command);
                if (uploadRequest != null)
                {
                    cover.ImageDataUrl = _uploadService.UploadAsync(uploadRequest);
                }
                await _unitOfWork.Repository<Cover>().AddAsync(cover);
                await _unitOfWork.Commit(cancellationToken);
                return await Result<int>.SuccessAsync(cover.Id, _localizer["Cover Saved"]);
            }
            else
            {
                var cover = await _unitOfWork.Repository<Cover>().GetByIdAsync(command.Id);
                if (cover != null)
                {
                    //cover. = command.Name ?? cover.Name;
                    cover.Description = command.Description ?? cover.Description;
                    if (uploadRequest != null)
                    {
                        cover.ImageDataUrl = _uploadService.UploadAsync(uploadRequest);
                    }
                    await _unitOfWork.Repository<Cover>().UpdateAsync(cover);
                    await _unitOfWork.Commit(cancellationToken);
                    return await Result<int>.SuccessAsync(cover.Id, _localizer["Cover Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Cover Not Found!"]);
                }
            }
        }
    }
}