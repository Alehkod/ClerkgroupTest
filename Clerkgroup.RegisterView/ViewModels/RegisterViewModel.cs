using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.RegisterView.Commands;
using Clerkgroup.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clerkgroup.RegisterView.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        public RegisterViewModel(UserStore userStore, IApiService apiService)
        {
            RegisterCommand = new RegisterCommand(userStore, apiService, this);
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICommand RegisterCommand { get; }
    }
}
