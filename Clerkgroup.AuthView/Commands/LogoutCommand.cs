using Clerkgroup.Application.Stores;
using Clerkgroup.Shared.Commands;

namespace Clerkgroup.AuthView.Commands
{
    public class LogoutCommand(UserStore userStore) : CommandBase
    {
        private readonly UserStore _userStore = userStore;

        public override void Execute(object? parameter)
        {
            _userStore.CurrentUser = null;
        }
    }
}
