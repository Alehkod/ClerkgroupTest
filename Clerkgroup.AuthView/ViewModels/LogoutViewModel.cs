using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.Commands;
using Clerkgroup.Shared;
using System.Windows.Input;

namespace Clerkgroup.AuthView.ViewModels
{
    public class LogoutViewModel(UserStore userStore) : ViewModelBase
    {
        public ICommand LogoutCommand { get; } = new LogoutCommand(userStore);
    }
}
