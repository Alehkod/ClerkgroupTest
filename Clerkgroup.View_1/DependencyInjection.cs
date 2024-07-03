using Clerkgroup.View_1.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Clerkgroup.View_1
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddView_1(this IServiceCollection services)
        {
            services.AddSingleton<ErrorViewModel>();
            services.AddSingleton<UserViewModel>();

            services.AddSingleton<ViewModel_1>();

            return services;
        }
    }
}
