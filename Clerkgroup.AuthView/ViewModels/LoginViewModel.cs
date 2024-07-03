using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.Commands;
using Clerkgroup.RegisterView.Views;
using Clerkgroup.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clerkgroup.AuthView.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginViewModel(UserStore userStore, IServiceProvider services, IApiService apiService)
        {
            LoginCommand = new LoginCommand(userStore, this, apiService);
            RegisterCommand = new RegisterCommand(userStore, services);
        }
    }
}
