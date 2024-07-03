using Clerkgroup.Application.Dto;
using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.AuthView.Commands
{
    public class LoginCommand : AsyncCommandBase
    {
        private readonly UserStore _userStore;
        private readonly LoginViewModel _loginViewModel;
        private readonly IApiService _apiService;

        public LoginCommand(UserStore userStore, LoginViewModel loginViewModel, IApiService apiService)
        {
            _userStore = userStore;
            _loginViewModel = loginViewModel;
            _apiService = apiService;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            await _apiService.LoginAsync(_loginViewModel.Username, _loginViewModel.Password, cancellationToken);
        }
    }
}
