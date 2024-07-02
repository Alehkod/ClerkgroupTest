using ClerkgroupTest.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.ViewModels.Components
{
    public class UserViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public string Text { get; } = "UserViewModel";

        public UserViewModel(NavigationStore navigationStore)
        {

            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
