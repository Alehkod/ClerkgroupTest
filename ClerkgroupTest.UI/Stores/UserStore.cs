using ClerkgroupTest.UI.Dto;

namespace ClerkgroupTest.UI.Stores
{
    public class UserStore
    {
        public UserDto? _currentUser;

        public UserStore()
        {
        }

        public UserDto? CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                CurrentUserChanged?.Invoke();
            }
        }

        public Action CurrentUserChanged;

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
