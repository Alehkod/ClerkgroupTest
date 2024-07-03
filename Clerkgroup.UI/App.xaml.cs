using Clerkgroup.Application;
using Clerkgroup.AuthView;
using Clerkgroup.NavigationBar;
using Clerkgroup.UI.ViewModel;
using Clerkgroup.UI.Views;
using Clerkgroup.View_1;
using Clerkgroup.View_2;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Clerkgroup.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public IServiceProvider Services { get; }
        public App()
        {
            Services = ConfigureServices();
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddApplication();

            //Controls
            services.AddAuthView();
            services.AddView_1();
            services.AddView_2();
            services.AddNavigationBar();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton(provider => new MainView()
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });

            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = Services.GetRequiredService<MainView>();

            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
