using Clerkgroup.NavigationBar.Commands;
using Clerkgroup.NavigationBar.Services;
using Clerkgroup.Shared;
using Clerkgroup.View_1.ViewModels;
using Clerkgroup.View_2.ViewModels;
using System.Windows.Input;

namespace Clerkgroup.NavigationBar.ViewModels
{
    public class NavigationBarViewModel(NavigationService<ViewModel_1> view_1NavigationService, NavigationService<ViewModel_2> view_2NavigationService) : ViewModelBase
    {
        public ICommand View_1Command { get; } = new NavigateCommand<ViewModel_1>(view_1NavigationService);
        public ICommand View_2Command { get; } = new NavigateCommand<ViewModel_2>(view_2NavigationService);
    }
}
