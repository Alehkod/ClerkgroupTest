using Clerkgroup.Application.Stores;
using Clerkgroup.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.AuthView.ViewModels
{
    public class AuthViewModel : ViewModelBase
    {
        private readonly UserStore _userStore;
        private readonly LoginViewModel _loginViewModel;
        private readonly LogoutViewModel _logoutViewModel;

        public AuthViewModel(UserStore userStore, LoginViewModel loginViewModel, LogoutViewModel logoutViewModel)
        {
            _userStore = userStore;
            _loginViewModel = loginViewModel;
            _logoutViewModel = logoutViewModel;

            _userStore.CurrentUserChanged += OnCurrentUserChanged;
        }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                if (_userStore.CurrentUser is null)
                    return _loginViewModel;

                return _logoutViewModel;
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
