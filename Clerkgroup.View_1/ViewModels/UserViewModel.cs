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

        public string Text => _userStore.CurrentUser.Name;
    }
}
