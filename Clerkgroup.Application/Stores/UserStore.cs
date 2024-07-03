using Clerkgroup.Application.Dto;

namespace Clerkgroup.Application.Stores
{
    public class UserStore
    {
        public UserDto? _currentUser;

        public UserDto? CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                CurrentUserChanged?.Invoke();
            }
        }

        public Action? CurrentUserChanged;

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
