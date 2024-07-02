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
    public class AuthAuthorizedViewModel : ViewModelBase
    {
        public ICommand LogoutCommand { get; }

        public AuthAuthorizedViewModel(UserStore userStore)
        {
            LogoutCommand = new LogoutCommand(userStore);
        }
    }
}
