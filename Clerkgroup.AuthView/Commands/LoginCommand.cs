using Clerkgroup.Application.Dto;
using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.AuthView.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly UserStore _userStore;
        private readonly LoginViewModel _loginViewModel;

        public LoginCommand(UserStore userStore, LoginViewModel loginViewModel)
        {
            _userStore = userStore;
            _loginViewModel = loginViewModel;
        }

        public override void Execute(object? parameter)
        {
            var user = new UserDto()
            {
                Name = _loginViewModel.Username
            };

            _userStore.CurrentUser = user;
        }
    }
}
