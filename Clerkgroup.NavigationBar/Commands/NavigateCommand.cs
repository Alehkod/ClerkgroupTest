using Clerkgroup.NavigationBar.Services;
using Clerkgroup.Shared;
using Clerkgroup.Shared.Commands;

namespace Clerkgroup.NavigationBar.Commands;

public class NavigateCommand<TViewModel>(NavigationService<TViewModel> navigationService) : CommandBase where TViewModel : ViewModelBase
{
    private readonly NavigationService<TViewModel> _navigationService = navigationService;

    public override void Execute(object? parameter)
    {
        _navigationService.Navigate();
    }
}
