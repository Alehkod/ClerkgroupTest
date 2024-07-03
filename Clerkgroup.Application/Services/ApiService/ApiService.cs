using Clerkgroup.Application.Dto;
using Clerkgroup.Application.Stores;
using Clerkgroup.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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
            //using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, @$"https://petstore.swagger.io/v2/user/{username}");            

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

        public Task LoginAsync(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task RegisterAsync()
        {
            throw new NotImplementedException();
        }

        public Task RegisterAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
