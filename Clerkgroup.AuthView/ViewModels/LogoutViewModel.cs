using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.Commands;
using Clerkgroup.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clerkgroup.AuthView.ViewModels
{
    public class LogoutViewModel : ViewModelBase
    {
        public ICommand LogoutCommand { get; }

        public LogoutViewModel(UserStore userStore)
        {
            LogoutCommand = new LogoutCommand(userStore);
        }
    }
}
