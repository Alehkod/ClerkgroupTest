using Clerkgroup.Application.Stores;
using Clerkgroup.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.AuthView.Commands
{
    public class LogoutCommand : CommandBase
    {
        private readonly UserStore _userStore;

        public LogoutCommand(UserStore userStore)
        {
            _userStore = userStore;
        }

        public override void Execute(object? parameter)
        {
            _userStore.CurrentUser = null;
        }
    }
}
