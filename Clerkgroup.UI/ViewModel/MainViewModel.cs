using Clerkgroup.Application.Stores;
using Clerkgroup.AuthView.ViewModels;
using Clerkgroup.Shared;
using Clerkgroup.View_1.ViewModels;
using Clerkgroup.View_2.ViewModels;
using NavigationBar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public NavigationBarViewModel NavigationBarViewModel { get; }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
