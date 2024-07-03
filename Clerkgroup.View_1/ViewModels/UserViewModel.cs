using Clerkgroup.Application.Stores;
using Clerkgroup.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clerkgroup.View_1.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private readonly UserStore _userStore;
        private string _title;

        public UserViewModel(UserStore userStore)
        {
            _userStore = userStore;
        }

        public string Id => _userStore.CurrentUser.Id.ToString();
        public string FirstName => _userStore.CurrentUser.FirstName;
        public string LastName => _userStore.CurrentUser.LastName;
        public string Email => _userStore.CurrentUser.Email;
        public string Phone => _userStore.CurrentUser.Phone;
    }
}
