using Clerkgroup.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.Application.Stores
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
