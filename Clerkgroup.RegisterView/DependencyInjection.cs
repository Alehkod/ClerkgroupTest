using Clerkgroup.RegisterView.ViewModels;
using Clerkgroup.RegisterView.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
