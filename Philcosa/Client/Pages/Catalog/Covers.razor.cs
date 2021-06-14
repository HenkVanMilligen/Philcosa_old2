using Philcosa.Application.Features.Covers.Queries.GetAllPaged;
using Philcosa.Application.Requests.Catalog;
using Philcosa.Client.Extensions;
using Philcosa.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Philcosa.Application.Features.Covers.Commands.AddEdit;
using Philcosa.Client.Models.Catalog;
using Microsoft.AspNetCore.Components.Forms;
using Philcosa.Application.Requests;
using System.IO;

namespace Philcosa.Client.Pages.Catalog
{
    public partial class Covers
    {
        private IEnumerable<GetAllPagedCoversResponse> pagedData;
        //private IEnumerable<GetAllPagedCoversViewModel> pagedVmData;
        private MudTable<GetAllPagedCoversResponse> table;

        private int totalItems;
        private int currentPage;
        private bool pageHasChanged = false;
        private string searchString = null;
        private bool _dense = true;
        private bool _striped = true;
        private bool _bordered = false;
        [CascadingParameter] public HubConnection hubConnection { get; set; }

        protected override async Task OnInitializedAsync()
        {
            hubConnection = hubConnection.TryInitialize(_navigationManager);
            if (hubConnection.State == HubConnectionState.Disconnected)
            {
                await hubConnection.StartAsync();
            }
        }

        private async Task<TableData<GetAllPagedCoversResponse>> ServerReload(TableState state)
        {
            if (pageHasChanged)
                await LoadData(state.Page, state.PageSize, state);
            else
                await LoadData(state.Page, 100, state);

            return new TableData<GetAllPagedCoversResponse>() { TotalItems = totalItems, Items = pagedData };
        }

        private ClaimsPrincipal AuthenticationStateProviderUser { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            AuthenticationStateProviderUser = await _stateProvider.GetAuthenticationStateProviderUserAsync();
        }

        private async Task LoadData(int pageNumber, int pageSize, TableState state)
        {
            pageHasChanged = true;
            var request = new GetAllPagedCoversRequest { PageSize = pageSize, PageNumber = pageNumber + 1, SearchString = searchString };
            var response = await _coverManager.GetCoversAsync(request);
            if (response.Succeeded)
            {
                totalItems = response.TotalCount;
                currentPage = response.CurrentPage;
                var data = response.Data;
                var loadedData = data.Where(element =>
                {
                    if (string.IsNullOrWhiteSpace(searchString))
                        return true;
                    if (element.CoverDate.ToString("yyyyMMdd").Contains(searchString, StringComparison.OrdinalIgnoreCase) == true)
                        return true;
                    if (element.Country?.Contains(searchString, StringComparison.OrdinalIgnoreCase) == true)
                        return true;
                    if (element.Description?.Contains(searchString, StringComparison.OrdinalIgnoreCase) == true)
                        return true;
                    //if (element.Barcode?.Contains(searchString, StringComparison.OrdinalIgnoreCase) == true)
                    //    return true;
                    return false;
                });
                switch (state.SortLabel)
                {
                    case "coverIdField":
                        loadedData = loadedData.OrderByDirection(state.SortDirection, p => p.Id);
                        break;
                    //case "coverNameField":
                    //    loadedData = loadedData.OrderByDirection(state.SortDirection, p => p.Name);
                    //    break;
                    //case "coverBrandField":
                    //    loadedData = loadedData.OrderByDirection(state.SortDirection, p => p.Brand);
                    //    break;
                    case "coverDescriptionField":
                        loadedData = loadedData.OrderByDirection(state.SortDirection, p => p.Description);
                        break;
                    //case "coverBarcodeField":
                    //    loadedData = loadedData.OrderByDirection(state.SortDirection, p => p.Barcode);
                    //    break;
                    //case "coverRateField":
                    //    loadedData = loadedData.OrderByDirection(state.SortDirection, p => p.Rate);
                    //    break;
                }
                data = loadedData.ToList();
                pagedData = data;
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(localizer[message], Severity.Error);
                }
            }
        }

        private void OnSearch(string text)
        {
            searchString = text;            
            table.ReloadServerData();
        }

        private async Task ExportToExcel()
        {
            var base64 = await _coverManager.ExportToExcelAsync();
            await _jsRuntime.InvokeVoidAsync("Download", new
            {
                ByteArray = base64,
                FileName = $"covers_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                MimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            });
        }

        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                var cover = pagedData.FirstOrDefault(c => c.Id == id);
                if (cover != null)
                {
                    parameters.Add(nameof(AddEditCoverModal.AddEditCoverModel), new AddEditCoverCommand
                    {
                        Id = cover.Id,
                        //Name = cover.Name,
                        Description = cover.Description,
                        //Rate = cover.Rate,
                        //BrandId = cover.BrandId,
                        //Barcode = cover.Barcode
                    });
                }
            }
            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.Medium, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditCoverModal>("Modal", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                OnSearch("");
            }
        }

        private async Task Delete(int id)
        {
            string deleteContent = localizer["Delete Content"];
            var parameters = new DialogParameters
            {
                {"ContentText", string.Format(deleteContent, id)}
            };
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<Shared.Dialogs.DeleteConfirmation>("Delete", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                var response = await _coverManager.DeleteAsync(id);
                if (response.Succeeded)
                {
                    OnSearch("");
                    await hubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
                    _snackBar.Add(localizer[response.Messages[0]], Severity.Success);
                }
                else
                {
                    OnSearch("");
                    foreach (var message in response.Messages)
                    {
                        _snackBar.Add(localizer[message], Severity.Error);
                    }
                }
            }
        }

        private void ShowBtnPress(int id)
        {
            var row = pagedData.FirstOrDefault(x => x.Id == id);
            row.ShowDetails = !row.ShowDetails;
        }
    }
}