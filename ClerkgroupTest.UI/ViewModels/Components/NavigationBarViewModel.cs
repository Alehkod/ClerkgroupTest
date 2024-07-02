using ClerkgroupTest.UI.Commands;
using ClerkgroupTest.UI.Services;
using ClerkgroupTest.UI.ViewModels.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClerkgroupTest.UI.ViewModels.Components
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public ICommand View_1Command { get; }
        public ICommand View_2Command { get; }

        public NavigationBarViewModel(LayoutNavigationService<ViewModel_1> view_1NavigationService, LayoutNavigationService<ViewModel_2> view_2NavigationService)
        {
            View_1Command = new NavigateCommand<ViewModel_1>(view_1NavigationService);
            View_2Command = new NavigateCommand<ViewModel_2>(view_2NavigationService);
        }
    }
}
