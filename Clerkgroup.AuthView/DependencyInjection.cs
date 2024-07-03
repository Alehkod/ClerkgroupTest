using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.RegisterView;
using Microsoft.Extensions.DependencyInjection;

namespace Clerkgroup.AuthView
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthView(this  IServiceCollection services)
        {
            services.AddRegisterView();

            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LogoutViewModel>();

            services.AddSingleton<AuthViewModel>();

            return services;
        }
    }
}
