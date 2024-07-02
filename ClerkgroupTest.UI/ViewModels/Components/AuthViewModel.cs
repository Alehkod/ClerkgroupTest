using ClerkgroupTest.UI.Stores;
using ClerkgroupTest.UI.ViewModels.Views;
using ClerkgroupTest.UI.Views.AuthView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.ViewModels.Components
{
    public class AuthViewModel : ViewModelBase
    {
        private readonly UserStore _userStore;
        private readonly AuthAuthorizedViewModel _authAuthorizedViewModel;
        private readonly AuthNoAuthorizedViewModel _authNoAuthorizedViewModel;

        public AuthViewModel(UserStore userStore, AuthAuthorizedViewModel authAuthorizedViewModel, AuthNoAuthorizedViewModel authNoAuthorizedViewModel)
        {
            _userStore = userStore;
            _authAuthorizedViewModel = authAuthorizedViewModel;
            _authNoAuthorizedViewModel = authNoAuthorizedViewModel;

            _userStore.CurrentUserChanged += OnCurrentUserChanged;
        }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                if (_userStore.CurrentUser is null)
                    return _authNoAuthorizedViewModel;

                return _authAuthorizedViewModel;
            }
        }

        private void OnCurrentUserChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public override void Dispose()
        {
            _userStore.CurrentUserChanged -= OnCurrentUserChanged;

            base.Dispose();
        }
    }
}
