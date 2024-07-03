using Clerkgroup.Application.Stores;
using Clerkgroup.Shared;

namespace Clerkgroup.View_1.ViewModels
{
    public class UserViewModel(UserStore userStore) : ViewModelBase
    {
        private readonly UserStore _userStore = userStore;

        public string? Id => _userStore.CurrentUser?.Id.ToString();
        public string? FirstName => _userStore.CurrentUser?.FirstName;
        public string? LastName => _userStore.CurrentUser?.LastName;
        public string? Email => _userStore.CurrentUser?.Email;
        public string? Phone => _userStore.CurrentUser?.Phone;
    }
}
