using Clerkgroup.View_2.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
