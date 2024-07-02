using Clerkgroup.Application.Stores;
using Microsoft.Extensions.DependencyInjection;

namespace Clerkgroup.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<NavigationStore>();
            services.AddSingleton<UserStore>();

            return services;
        }
    }
}
