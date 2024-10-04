using Blazored.SessionStorage;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using WebAthenPs.Project.Services.Authentication;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.User;
using WebAthenPs.Project.Services.Interfaces.User;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace WebAthenPs.Project.Services.Implementation.User
{
    public class AuthService : IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ISessionStorageService _sessionStorage;
        private readonly ILocalStorageService _localStorage;

        public AuthService(IHttpClientFactory httpClientFactory,
            AuthenticationStateProvider authenticationStateProvider,
            ISessionStorageService sessionStorage,
            ILocalStorageService localStorage)
        {
            _httpClientFactory = httpClientFactory;
            _authenticationStateProvider = authenticationStateProvider;
            _sessionStorage = sessionStorage;
            _localStorage = localStorage;
        }



        public async Task<LoginResult> Login(LoginModel loginModel, bool rememberMe)
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
                    await SetCredentials(loginResult.Token, loginResult.UserId, rememberMe);

                    // Armazena o nome do usuário diretamente na resposta
                    await _sessionStorage.SetItemAsync("userName", loginModel.Email);

                    // Se "lembrar-me" estiver marcado, também armazena no LocalStorage
                    if (rememberMe)
                    {
                        await _localStorage.SetItemAsync("userName", loginModel.Email);
                    }

                    ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);

                    httpClient.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", loginResult.Token);

                    return loginResult;
                }
            }

            return new LoginResult { Token = string.Empty };
        }

        public async Task Logout()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");

            // Remover apenas do SessionStorage
            await _sessionStorage.RemoveItemAsync("authToken");
            await _sessionStorage.RemoveItemAsync("userId");
            await _sessionStorage.RemoveItemAsync("userName");

            ((APIAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }



        private string Encrypt(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty; // Evita passar strings vazias ou nulas
            }

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }

        private string Decrypt(string encryptedData)
        {
            if (string.IsNullOrEmpty(encryptedData))
            {
                return string.Empty; // Retorna vazio ou lida de acordo com suas necessidades
            }

            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(encryptedData));
            }
            catch (FormatException)
            {
                Console.WriteLine("O dado fornecido não está no formato Base64 correto.");
                throw; // Lança novamente a exceção ou trate de outra maneira
            }
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
                        return registerResult.UserId; // Retorne o UserId do usuário registrado
                    }
                }

                return null; // Retorne null se não for possível obter o UserId
            }
            catch (Exception)
            {
                throw; // Trate a exceção conforme necessário
            }
        }

        private async Task SetCredentials(string token, string userId, bool rememberMe)
        {
            string encryptedToken = Encrypt(token);
            string encryptedUserId = Encrypt(userId);

            // Sempre armazene no SessionStorage
            await _sessionStorage.SetItemAsync("authToken", encryptedToken);
            await _sessionStorage.SetItemAsync("userId", encryptedUserId);

            // Se "lembrar-me" estiver marcado, armazene também no LocalStorage
            if (rememberMe)
            {
                await _localStorage.SetItemAsync("authToken", encryptedToken);
                await _localStorage.SetItemAsync("userId", encryptedUserId);
            }
        }

        public async Task<string> GetUserIdFromToken()
        {
            // Obtém o token usando o método GetToken
            var decryptedToken = await GetToken();

            if (string.IsNullOrEmpty(decryptedToken))
            {
                throw new Exception("O token descriptografado está vazio.");
            }

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(decryptedToken); // Lê o token JWT
                return jwtToken.Claims.FirstOrDefault(c => c.Type == "sub")?.Value; // Retorna o UserId
            }
            catch (SecurityTokenMalformedException ex)
            {
                Console.WriteLine("Token JWT está malformado.");
                throw new Exception("Token JWT está malformado.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado ao ler o token JWT.");
                throw new Exception("Erro inesperado ao ler o token JWT.", ex);
            }
        }


        public async Task<bool> IsLoggedIn()
        {
            var encryptedToken = await _sessionStorage.GetItemAsync<string>("authToken");
            var decryptedToken = Decrypt(encryptedToken); // Descriptografa o token

            return !string.IsNullOrEmpty(decryptedToken); // Verifica se o token descriptografado existe
        }

        public async Task<string> GetToken()
        {
            // Primeiro, tente obter o token do LocalStorage
            var encryptedToken = await _sessionStorage.GetItemAsync<string>("authToken");

            var decryptedToken = !string.IsNullOrEmpty(encryptedToken) ? Decrypt(encryptedToken) : string.Empty;

            // Verifica se o token está expirado
            if (!string.IsNullOrEmpty(decryptedToken) && IsTokenExpired(decryptedToken))
            {
                Console.WriteLine("O token está expirado.");
                return string.Empty; // Ou lance uma exceção, dependendo de como você deseja tratar
            }

            return decryptedToken;
        }
        private bool IsTokenExpired(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var expiration = jwtToken.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Exp)?.Value;

            if (long.TryParse(expiration, out var expUnix))
            {
                var expDateTime = DateTimeOffset.FromUnixTimeSeconds(expUnix).UtcDateTime;
                return expDateTime < DateTime.UtcNow;
            }
            return true; // Considera expirado se não puder ser analisado
        }






    }
}
