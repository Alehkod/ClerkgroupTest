using ClerkgroupTest.UI.Dto;
using ClerkgroupTest.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClerkgroupTest.UI.ViewModels.Views
{
    public class ViewModel_1 : ViewModelBase
    {
        private readonly UserStore _userStore;
        private readonly ViewModel_1NoAuthorized _viewModel_1NoAuthorized;
        private readonly ViewModel_1Authorized _viewModel_1Authorized;

        public string Text { get; } = "ViewModel_1";


        public ViewModel_1(UserStore userStore, ViewModel_1NoAuthorized viewModel_1NoAuthorized, ViewModel_1Authorized viewModel_1Authorized)
        {
            _userStore = userStore;
            _viewModel_1NoAuthorized = viewModel_1NoAuthorized;
            _viewModel_1Authorized = viewModel_1Authorized;
            _userStore.CurrentUserChanged += OnCurrentUserChanged;
        }

        private void OnCurrentUserChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                if (_userStore.CurrentUser is null)
                    return _viewModel_1NoAuthorized;

                return _viewModel_1Authorized;
            }
        }

        public override void Dispose()
        {
            _userStore.CurrentUserChanged -= OnCurrentUserChanged;

            base.Dispose();
        }
    }
}
