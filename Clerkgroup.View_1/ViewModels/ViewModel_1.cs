using Clerkgroup.Application.Stores;
using Clerkgroup.Shared;

namespace Clerkgroup.View_1.ViewModels
{
    public class ViewModel_1 : ViewModelBase
    {
        private readonly UserStore _userStore;
        private readonly ErrorViewModel _errorViewModel;
        private readonly UserViewModel _userViewModel;

        public ViewModel_1(UserStore userStore, ErrorViewModel errorViewModel, UserViewModel userViewModel)
        {
            _userStore = userStore;
            _errorViewModel = errorViewModel;
            _userViewModel = userViewModel;

            _userStore.CurrentUserChanged += OnCurrentUserChanged;
        }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                if (_userStore.CurrentUser is null)
                    return _errorViewModel;

                return _userViewModel;
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
