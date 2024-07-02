using ClerkgroupTest.UI.Services;
using ClerkgroupTest.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly LayoutNavigationService<TViewModel> _navigationService;

        public NavigateCommand(LayoutNavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }
        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
