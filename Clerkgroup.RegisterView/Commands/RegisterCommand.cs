using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.Domain;
using Clerkgroup.RegisterView.ViewModels;
using Clerkgroup.Shared.Commands;
using System.Windows;

namespace Clerkgroup.RegisterView.Commands
{
    public class RegisterCommand(IApiService apiService, RegisterViewModel registerViewModel) : AsyncCommandBase
    {
        private readonly IApiService _apiService = apiService;
        private readonly RegisterViewModel _registerViewModel = registerViewModel;

        public override async Task ExecuteAsync(object parameter)
        {
            if (_registerViewModel.Username == null || _registerViewModel.Password == null)
            {
                return;
            }

            User user = new()
            {
                Username = _registerViewModel.Username,
                Password = _registerViewModel.Password,
                Email = _registerViewModel.Email,
                FirstName = _registerViewModel.FirstName,
                LastName = _registerViewModel.LastName,
                Phone = _registerViewModel.Phone
            };

            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            await _apiService.RegisterAsync(user, cancellationToken);

            ((Window)parameter).Close();
        }
    }
}
