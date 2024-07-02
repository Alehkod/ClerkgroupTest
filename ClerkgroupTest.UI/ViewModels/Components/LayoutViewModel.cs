using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkgroupTest.UI.ViewModels.Components
{
    public class LayoutViewModel : ViewModelBase
    {
        public NavigationBarViewModel NavigationBarViewModel { get; }
        public AuthViewModel AuthViewModel { get; }
        public UserViewModel UserViewModel { get; }


        public LayoutViewModel(NavigationBarViewModel navigationBarViewModel, AuthViewModel authViewModel, UserViewModel userViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
            AuthViewModel = authViewModel;
            UserViewModel = userViewModel;
        }
    }
}
