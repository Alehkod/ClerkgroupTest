using ClerkgroupTest.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.Commands
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
