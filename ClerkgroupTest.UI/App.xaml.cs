using ClerkgroupTest.UI.Services;
using ClerkgroupTest.UI.Stores;
using ClerkgroupTest.UI.ViewModels.Components;
using ClerkgroupTest.UI.ViewModels.Views;
using ClerkgroupTest.UI.ViewModels.Windows;
using ClerkgroupTest.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ClerkgroupTest.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();


            services.AddSingleton<LayoutViewModel>();
            services.AddSingleton<NavigationBarViewModel>();
            services.AddSingleton<UserViewModel>();
            services.AddSingleton<AuthViewModel>();


            services.AddSingleton<ViewModel_1Authorized>();
            services.AddSingleton<ViewModel_1NoAuthorized>();
            services.AddSingleton<AuthAuthorizedViewModel>();
            services.AddSingleton<AuthNoAuthorizedViewModel>();



            services.AddSingleton<ViewModel_1>();
            services.AddSingleton<Func<ViewModel_1>>((s) => () => s.GetRequiredService<ViewModel_1>());
            services.AddSingleton<LayoutNavigationService<ViewModel_1>>();

            services.AddSingleton<ViewModel_2>();
            services.AddSingleton<Func<ViewModel_2>>((s) => () => s.GetRequiredService<ViewModel_2>());
            services.AddSingleton<LayoutNavigationService<ViewModel_2>>();



            services.AddSingleton<NavigationStore>();
            services.AddSingleton<UserStore>();

            services.AddSingleton<MainViewModel>();



            services.AddSingleton(provider => new MainView()
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });

            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            var window = Services.GetRequiredService<MainView>();
            MainWindow = window;



            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
