using Clerkgroup.AuthView.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.AuthView
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthView(this  IServiceCollection services)
        {
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LogoutViewModel>();

            services.AddSingleton<AuthViewModel>();

            return services;
        }
    }
}
