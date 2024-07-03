using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.AuthView.Commands;
using Clerkgroup.Shared;
using System.Windows.Input;

namespace Clerkgroup.AuthView.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string? _username;
        private string? _password;

        public string? Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string? Password
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

        public LoginViewModel(IServiceProvider services, IApiService apiService)
        {
            LoginCommand = new LoginCommand(this, apiService);
            RegisterCommand = new RegisterCommand(services);
        }
    }
}
