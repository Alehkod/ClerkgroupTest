using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.Shared.Commands;

namespace Clerkgroup.AuthView.Commands
{
    public class LoginCommand(LoginViewModel loginViewModel, IApiService apiService) : AsyncCommandBase
    {
        private readonly LoginViewModel _loginViewModel = loginViewModel;
        private readonly IApiService _apiService = apiService;

        public override async Task ExecuteAsync(object parameter)
        {
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            if (_loginViewModel.Username == null || _loginViewModel.Password == null)
            {
                return;
            }

            await _apiService.LoginAsync(_loginViewModel.Username, _loginViewModel.Password, cancellationToken);
        }
    }
}
