using Clerkgroup.NavigationBar.Services;
using Clerkgroup.NavigationBar.ViewModels;
using Clerkgroup.View_1.ViewModels;
using Clerkgroup.View_2.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.NavigationBar
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddNavigationBar(this IServiceCollection services)
        {
            services.AddSingleton<NavigationBarViewModel>();

            services.AddSingleton<Func<ViewModel_1>>((s) => () => s.GetRequiredService<ViewModel_1>());
            services.AddSingleton<NavigationService<ViewModel_1>>();

            services.AddSingleton<Func<ViewModel_2>>((s) => () => s.GetRequiredService<ViewModel_2>());
            services.AddSingleton<NavigationService<ViewModel_2>>();

            return services;
        }
    }    
}
