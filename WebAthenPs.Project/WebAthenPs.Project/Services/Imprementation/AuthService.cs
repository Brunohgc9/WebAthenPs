using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using WebAthenPs.Models.Models;
using WebAthenPs.Project.Services.Authentication;
using WebAthenPs.Project.Services.Interfaces;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class AuthService : IAuthService
    {
        private readonly ILogger<AuthService> _logger; // Corrigido para ILogger<AuthService>
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorageService;

        public AuthService(IHttpClientFactory httpClientFactory, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorageService, ILogger<AuthService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorageService = localStorageService;
            _logger = logger; // Inicialização do logger
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var loginAsJson = JsonSerializer.Serialize(loginModel);
                var requestContent = new StringContent(loginAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Users/Login", requestContent);

                // Log response status and content
                var responseContent = await response.Content.ReadAsStringAsync();
                _logger.LogInformation($"Response status: {response.StatusCode}");
                _logger.LogInformation($"Response content: {responseContent}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Failed to login: {responseContent}");
                    return new LoginResult { ErrorMessage = responseContent };
                }

                var loginResult = JsonSerializer.Deserialize<LoginResult>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (loginResult == null)
                {
                    _logger.LogError("Deserialization failed. The response content is not valid JSON.");
                    return new LoginResult { ErrorMessage = "Deserialization failed." };
                }

                await _localStorageService.SetItemAsync("authToken", loginResult.Token);
                await _localStorageService.SetItemAsync("tokenExpiration", loginResult.Expiration);

                ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);

                return loginResult;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error during login.");
                return new LoginResult { ErrorMessage = "Unexpected error: " + ex.Message };
            }
        }


        public async Task Logout()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            await _localStorageService.RemoveItemAsync("authToken");

            ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
