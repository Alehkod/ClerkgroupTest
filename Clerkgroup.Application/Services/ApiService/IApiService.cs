using Clerkgroup.Application.Dto;
using Clerkgroup.Domain;

namespace Clerkgroup.Application.Services.ApiService
{
    public interface IApiService
    {
        Task RegisterAsync(User user, CancellationToken cancellationToken);
        Task LoginAsync(string username, string password, CancellationToken cancellationToken);
        Task LogoutAsync(CancellationToken cancellationToken);
        Task<UserDto?> GetUserAsync(string username, CancellationToken cancellationToken);
    }
}
