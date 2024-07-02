using ClerkgroupTest.UI.Commands;
using ClerkgroupTest.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClerkgroupTest.UI.ViewModels.Views
{
    public class AuthNoAuthorizedViewModel : ViewModelBase
    {
        private string _username;
        private string _password;

        public string UserName
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }

        public AuthNoAuthorizedViewModel(UserStore userStore)
        {
            LoginCommand = new LoginCommand(userStore, this);
        }
    }
}
