﻿using Microsoft.AspNetCore.Components.Authorization;

namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authenticationState;

        public AuthService(HttpClient http,
            AuthenticationStateProvider authenticationState)
        {
            _http = http;
            _authenticationState = authenticationState;
        }

        public async Task<bool> IsUserAuthenticated()
        {
            return (await _authenticationState.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/change-password", request.Password); 

            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }


        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
