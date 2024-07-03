using Clerkgroup.Shared.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Clerkgroup.AuthView.Commands
{
    public class RegisterCommand(IServiceProvider services) : CommandBase
    {
        private readonly IServiceProvider _services = services;

        public override void Execute(object? parameter)
        {
            var registerView = _services.GetRequiredService<RegisterView.Views.RegisterView>();
            registerView.ShowDialog();
        }
    }
}
