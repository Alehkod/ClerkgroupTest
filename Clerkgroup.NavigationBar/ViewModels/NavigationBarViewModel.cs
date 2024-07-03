using Clerkgroup.NavigationBar.Commands;
using Clerkgroup.NavigationBar.Services;
using Clerkgroup.Shared;
using Clerkgroup.View_1.ViewModels;
using Clerkgroup.View_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Clerkgroup.NavigationBar.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public ICommand View_1Command { get; }
        public ICommand View_2Command { get; }

        public NavigationBarViewModel(NavigationService<ViewModel_1> view_1NavigationService, NavigationService<ViewModel_2> view_2NavigationService)
        {
            View_1Command = new NavigateCommand<ViewModel_1>(view_1NavigationService);
            View_2Command = new NavigateCommand<ViewModel_2>(view_2NavigationService);
        }
    }
}
