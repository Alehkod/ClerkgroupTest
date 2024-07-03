using Clerkgroup.Application.Dto;
using Clerkgroup.Application.Stores;
using Clerkgroup.Domain;
using System.Net.Http.Json;

namespace Clerkgroup.Application.Services.ApiService
{
    public class ApiService : IApiService
    {
        private readonly UserStore _userStore;
        private readonly HttpClient _httpClient;

        public ApiService(UserStore userStore)
        {
            _userStore = userStore;

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(@"https://petstore.swagger.io")
            };
        }

        public async Task<UserDto?> GetUserAsync(string username, CancellationToken cancellationToken)
        {
            try
            {
                UserDto? user;
                user = await _httpClient.GetFromJsonAsync<UserDto?>(@$"https://petstore.swagger.io/v2/user/{username}", cancellationToken);

                return user;
            }
            catch(HttpRequestException)
            {
                return null;
            }      
        }

        public async Task LoginAsync(string username, string password, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($@"https://petstore.swagger.io/v2/user/login?username={username}&password={password}", cancellationToken);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return;

            var user = await GetUserAsync(username, cancellationToken);

            _userStore.CurrentUser = user;
        }

        public async Task LogoutAsync(CancellationToken cancellationToken)
        {
            await _httpClient.GetAsync(@"https://petstore.swagger.io/v2/user/logout");
        }

        public async Task RegisterAsync(User user, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PostAsJsonAsync<User>(@"https://petstore.swagger.io/v2/user", user, cancellationToken);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return;

            await LoginAsync(user.Username, user.Password, cancellationToken);
        }
    }
}
