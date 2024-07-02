using ClerkgroupTest.UI.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.ViewModels.Views
{
    public class ViewModel_1Authorized : ViewModelBase
    {
        private readonly UserStore _userStore;

        public string Text => _userStore.CurrentUser.Name;

        public ViewModel_1Authorized(UserStore userStore)
        {
            _userStore = userStore;
        }
    }
}
