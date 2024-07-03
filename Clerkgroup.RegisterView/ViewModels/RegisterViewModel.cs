using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.RegisterView.Commands;
using Clerkgroup.Shared;
using System.Windows.Input;

namespace Clerkgroup.RegisterView.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        public RegisterViewModel(IApiService apiService)
        {
            RegisterCommand = new RegisterCommand(apiService, this);
        }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public ICommand RegisterCommand { get; }
    }
}
