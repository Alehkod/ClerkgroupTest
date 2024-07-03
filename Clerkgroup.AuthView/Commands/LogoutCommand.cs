using Clerkgroup.Application.Services.ApiService;
using Clerkgroup.Application.Stores;
using Clerkgroup.Shared.Commands;

namespace Clerkgroup.AuthView.Commands
{
    public class LogoutCommand(UserStore userStore, IApiService apiService) : AsyncCommandBase
    {
        private readonly UserStore _userStore = userStore;
        private readonly IApiService _apiService = apiService;
        
        public override async Task ExecuteAsync(object parameter)
        {
            CancellationToken cancellationToken = new CancellationTokenSource().Token;

            await _apiService.LogoutAsync(cancellationToken);

            _userStore.CurrentUser = null;
        }
    }
}
