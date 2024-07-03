using Clerkgroup.Application.Dto;
using Clerkgroup.Domain;

namespace Clerkgroup.Application.Services.ApiService
{
    public interface IApiService
    {
        Task RegisterAsync(User user);
        Task LoginAsync(string login, string password);
        Task LogoutAsync();
        Task<UserDto?> GetUserAsync(string username, CancellationToken cancellationToken);
    }
}
