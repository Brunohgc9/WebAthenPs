using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using WebAthenPs.Models.Models;
using WebAthenPs.Project.Services.Authentication;
using WebAthenPs.Project.Services.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class AuthService : IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly IGenericProfessionalService _genericProfessionalService;
        private readonly NavigationManager _navigationManager;

        public AuthService(IHttpClientFactory httpClientFactory,
            AuthenticationStateProvider authenticationStateProvider,
            ILocalStorageService localStorage,
            IGenericProfessionalService genericProfessionalService,
            NavigationManager navigationManager)
        {
            _httpClientFactory = httpClientFactory;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
            _genericProfessionalService = genericProfessionalService;
            _navigationManager = navigationManager;
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var loginAsJson = JsonSerializer.Serialize(loginModel);
                var requestContent = new StringContent(loginAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Users/Login", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var loginResult = JsonSerializer.Deserialize<LoginResult>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (loginResult != null)
                    {
                        await _localStorage.SetItemAsync("authToken", loginResult.Token);
                        await _localStorage.SetItemAsync("tokenExpiration", loginResult.Expiration);
                        await _localStorage.SetItemAsync("userName", loginModel.Email); // Armazena o nome

                        ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);

                        httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("bearer", loginResult.Token);

                        // Verifica se o usuário é um profissional
                        var userId = await _localStorage.GetItemAsync<string>("userId");
                        if (!string.IsNullOrEmpty(userId))
                        {
                            var professional = await _genericProfessionalService.GetById(int.Parse(userId));
                            if (professional == null || string.IsNullOrEmpty(professional.ProfessionalType))
                            {
                                // Se não tiver tipo de profissional, redireciona para a página de registro
                                _navigationManager.NavigateTo("/register-professional");
                            }
                        }

                        return loginResult;
                    }
                }
                return new LoginResult { Token = string.Empty }; // Indica falha no login
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Logout()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            await _localStorage.RemoveItemAsync("authToken");

            ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<bool> Register(RegisterModel registerModel)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var registerAsJson = JsonSerializer.Serialize(registerModel);
                var requestContent = new StringContent(registerAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Users/Register", requestContent);

                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
