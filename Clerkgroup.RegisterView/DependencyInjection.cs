using Clerkgroup.RegisterView.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Clerkgroup.RegisterView
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRegisterView(this  IServiceCollection services)
        {
            services.AddTransient<RegisterViewModel>();

            services.AddTransient(provider => new Views.RegisterView
            {
                DataContext = provider.GetRequiredService<RegisterViewModel>()
            });

            return services;
        }
    }
}
