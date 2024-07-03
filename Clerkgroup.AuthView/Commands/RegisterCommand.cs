using Clerkgroup.Application.Dto;
using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.RegisterView.Views;
using Clerkgroup.Shared.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.AuthView.Commands
{
    public class RegisterCommand : CommandBase
    {
        private readonly UserStore _userStore;
        private readonly IServiceProvider _services;
        private readonly LoginViewModel _loginViewModel;

        public RegisterCommand(UserStore userStore, IServiceProvider services)
        {
            _userStore = userStore;
            _services = services;
        }

        public override void Execute(object? parameter)
        {
            var registerView = _services.GetRequiredService<RegisterView.Views.RegisterView>();
            registerView.ShowDialog();
        }
    }
}
