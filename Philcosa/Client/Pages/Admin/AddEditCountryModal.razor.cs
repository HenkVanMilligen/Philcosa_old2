//using Philcosa.Client.Extensions;
//using Philcosa.Shared.Constants.Application;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.SignalR.Client;
//using MudBlazor;
//using System.Threading.Tasks;
//using Blazored.FluentValidation;
//using Philcosa.Application.Features.Countries.Commands.AddEdit;

//namespace Philcosa.Client.Pages.Admin
//{
//    public partial class AddEditCountryModal : ComponentBase
//    {
//        [Inject] private Microsoft.Extensions.Localization.IStringLocalizer<AddEditCountryModal> localizer { get; set; }

//        private FluentValidationValidator _fluentValidationValidator;
//        private bool validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

//        [Parameter]
//        public AddEditCountryCommand AddEditCountryModel { get; set; } = new();

//        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
//        [CascadingParameter] public HubConnection hubConnection { get; set; }

//        public void Cancel()
//        {
//            MudDialog.Cancel();
//        }

//        private async Task SaveAsync()
//        {
//            var response = await _countryManager.SaveAsync(AddEditCountryModel);
//            if (response.Succeeded)
//            {
//                _snackBar.Add(localizer[response.Messages[0]], Severity.Success);
//                MudDialog.Close();
//            }
//            else
//            {
//                foreach (var message in response.Messages)
//                {
//                    _snackBar.Add(localizer[message], Severity.Error);
//                }
//            }
//            await hubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
//        }

//        protected override async Task OnInitializedAsync()
//        {
//            await LoadDataAsync();
//            hubConnection = hubConnection.TryInitialize(_navigationManager);
//            if (hubConnection.State == HubConnectionState.Disconnected)
//            {
//                await hubConnection.StartAsync();
//            }
//        }

//        private async Task LoadDataAsync()
//        {
//            await Task.CompletedTask;
//        }
//    }
//}