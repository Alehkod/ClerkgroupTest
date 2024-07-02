using ClerkgroupTest.UI.Dto;
using ClerkgroupTest.UI.Stores;
using ClerkgroupTest.UI.ViewModels.Components;
using ClerkgroupTest.UI.ViewModels.Views;
using ClerkgroupTest.UI.Views.AuthView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly UserStore _userStore;
        private readonly AuthNoAuthorizedViewModel _authViewModel;

        public LoginCommand(UserStore userStore, AuthNoAuthorizedViewModel authViewModel)
        {
            _userStore = userStore;
            _authViewModel = authViewModel;
        }

        public override void Execute(object? parameter)
        {
            var user = new UserDto()
            {
                Name = _authViewModel.UserName
            };

            _userStore.CurrentUser = user;
        }
    }
}
