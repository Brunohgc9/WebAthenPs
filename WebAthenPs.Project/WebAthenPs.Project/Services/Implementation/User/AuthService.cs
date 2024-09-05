using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using WebAthenPs.Project.Services.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WebAthenPs.Models.DTOs.User;
using WebAthenPs.Project.Services.Interfaces.User;

namespace WebAthenPs.Project.Services.Implementation.User
{
    public class AuthService : IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly NavigationManager _navigationManager;

        public AuthService(IHttpClientFactory httpClientFactory,
            AuthenticationStateProvider authenticationStateProvider,
            ILocalStorageService localStorage,
            NavigationManager navigationManager)
        {
            _httpClientFactory = httpClientFactory;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
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
                        // Armazenar dados no LocalStorage
                        await _localStorage.SetItemAsync("authToken", loginResult.Token);
                        await _localStorage.SetItemAsync("tokenExpiration", loginResult.Expiration);
                        await _localStorage.SetItemAsync("userName", loginModel.Email);
                        await _localStorage.SetItemAsync("userId", loginResult.UserId); // Armazene o UserId

                        ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);

                        // Configurar o cabeçalho de autorização para a próxima requisição
                        httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("bearer", loginResult.Token);

                        // Retornar o LoginResult com Token e UserId
                        return new LoginResult { Token = loginResult.Token, UserId = loginResult.UserId };
                    }
                }

                // Retornar um LoginResult indicando falha no login
                return new LoginResult { Token = string.Empty };
            }
            catch (Exception)
            {
                // Tratar exceções e relançar
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

        public async Task<string?> Register(RegisterModel registerModel)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var registerAsJson = JsonSerializer.Serialize(registerModel);
                var requestContent = new StringContent(registerAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Users/Register", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var registerResult = JsonSerializer.Deserialize<RegisterResult>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (registerResult != null)
                    {
                        // Retorne o UserId do usuário registrado
                        return registerResult.UserId;
                    }
                }

                // Retorne null se não for possível obter o UserId
                return null;
            }
            catch (Exception)
            {
                // Trate a exceção conforme necessário
                throw;
            }
        }



    }
}
