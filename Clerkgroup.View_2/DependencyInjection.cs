using Clerkgroup.View_2.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Clerkgroup.View_2
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddView_2(this IServiceCollection services)
        {
            services.AddSingleton<ViewModel_2>();

            return services;
        }
    }
}
