using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.Domain;
using Clerkgroup.RegisterView.ViewModels;
using Clerkgroup.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Clerkgroup.RegisterView.Commands
{
    public class RegisterCommand : AsyncCommandBase
    {
        private readonly UserStore _userStore;
        private readonly IApiService _apiService;
        private readonly RegisterViewModel _registerViewModel;

        public RegisterCommand(UserStore userStore, IApiService apiService, RegisterViewModel registerViewModel)
        {
            _userStore = userStore;
            _apiService = apiService;
            _registerViewModel = registerViewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            User user = new User
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
