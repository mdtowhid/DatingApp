using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using CertificateWebApp.Client.AuthProviders;
using CertificateWebApp.Shared.Interfaces;
using CertificateWebApp.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace CertificateWebApp.Client.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ISessionStorageService _sessionStorage;


        public AuthenticationService(HttpClient client, AuthenticationStateProvider authStateProvider, ISessionStorageService sessionStorage)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _authStateProvider = authStateProvider;
            _sessionStorage = sessionStorage;
        }

        public async Task<AuthResponseDto> Login(User user)
        {
            try
            {
                var content = JsonSerializer.Serialize(user);
                var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

                var authResult = await _client.PostAsync("/api/Accounts/login", bodyContent);
                var authContent = await authResult.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<AuthResponseDto>(authContent, _options);

                if (!authResult.IsSuccessStatusCode)
                    return result;

                await _sessionStorage.SetItemAsync("authToken", result.Token);
                ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(user.Email);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);

                return new AuthResponseDto { IsAuthSuccessful = true };
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task Logout()
        {
            await _sessionStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }
    }
}
