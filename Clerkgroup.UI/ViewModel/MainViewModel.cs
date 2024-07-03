using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.NavigationBar.ViewModels;
using Clerkgroup.Shared;

namespace Clerkgroup.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public MainViewModel(AuthViewModel authViewModel, NavigationStore navigationStore, NavigationBarViewModel navigationBarViewModel)
        {
            AuthViewModel = authViewModel;
            _navigationStore = navigationStore;
            NavigationBarViewModel = navigationBarViewModel;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        public AuthViewModel AuthViewModel { get; }
        public ViewModelBase? CurrentViewModel => _navigationStore.CurrentViewModel;
        public NavigationBarViewModel NavigationBarViewModel { get; }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
