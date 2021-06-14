using Philcosa.Application.Features.Covers.Commands.AddEdit;
using Philcosa.Application.Requests;
using Philcosa.Client.Extensions;
using Philcosa.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Blazored.FluentValidation;

namespace Philcosa.Client.Pages.Catalog
{
    public partial class AddEditCoverModal
    {
        [Inject] private Microsoft.Extensions.Localization.IStringLocalizer<AddEditCoverModal> localizer { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        [Parameter]
        public AddEditCoverCommand AddEditCoverModel { get; set; } = new();

        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] public HubConnection hubConnection { get; set; }

        public void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            var response = await _coverManager.SaveAsync(AddEditCoverModel);
            if (response.Succeeded)
            {
                _snackBar.Add(localizer[response.Messages[0]], Severity.Success);
                await hubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
                MudDialog.Close();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(localizer[message], Severity.Error);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            hubConnection = hubConnection.TryInitialize(_navigationManager);
            if (hubConnection.State == HubConnectionState.Disconnected)
            {
                await hubConnection.StartAsync();
            }
        }

        private async Task LoadDataAsync()
        {
            await LoadImageAsync();
            //await LoadBrandsAsync();
        }

        //private async Task LoadBrandsAsync()
        //{
        //    var data = await _brandManager.GetAllAsync();
        //    if (data.Succeeded)
        //    {
        //        Brands = data.Data;
        //    }
        //}

        private async Task LoadImageAsync()
        {
            var data = await _coverManager.GetCoverImageAsync(AddEditCoverModel.Id);
            if (data.Succeeded)
            {
                var imageData = data.Data;
                if (!string.IsNullOrEmpty(imageData))
                {
                    AddEditCoverModel.ImageDataURL = imageData;
                }
            }
        }

        private void DeleteAsync()
        {
            AddEditCoverModel.ImageDataURL = null;
            AddEditCoverModel.UploadRequest = new UploadRequest();
        }

        public IBrowserFile file { get; set; }

        private async Task UploadFiles(InputFileChangeEventArgs e)
        {
            file = e.File;
            if (file != null)
            {
                var extension = Path.GetExtension(file.Name);
                var format = "image/png";
                var imageFile = await e.File.RequestImageFileAsync(format, 400, 400);
                var buffer = new byte[imageFile.Size];
                await imageFile.OpenReadStream().ReadAsync(buffer);
                AddEditCoverModel.ImageDataURL = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
                AddEditCoverModel.UploadRequest = new UploadRequest { Data = buffer, UploadType = Application.Enums.UploadType.Cover, Extension = extension };
            }
        }
    }
}