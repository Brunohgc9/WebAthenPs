using Blazored.SessionStorage;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;
using System.Text;

namespace WebAthenPs.Project.Services.Authentication
{
    public class APIAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStorage;
        private readonly ILocalStorageService _localStorage;

        public APIAuthenticationStateProvider(ISessionStorageService sessionStorage, ILocalStorageService localStorage)
        {
            _sessionStorage = sessionStorage;
            _localStorage = localStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var encryptedToken = await _sessionStorage.GetItemAsync<string>("authToken");

            if (string.IsNullOrWhiteSpace(encryptedToken))
            {
                encryptedToken = await _localStorage.GetItemAsync<string>("authToken");

                if (!string.IsNullOrWhiteSpace(encryptedToken))
                {
                    var token = Decrypt(encryptedToken);
                    if (string.IsNullOrWhiteSpace(token))
                    {
                        Console.WriteLine("Token descriptografado está vazio.");
                        return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
                    }

                    // Marque o usuário como autenticado
                    MarkUserAsAuthenticatedFromToken(token);
                }
            }
            else
            {
                var token = Decrypt(encryptedToken);
                if (string.IsNullOrWhiteSpace(token))
                {
                    Console.WriteLine("Token descriptografado está vazio.");
                    return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
                }

                return new AuthenticationState(new ClaimsPrincipal(
                   new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt")));
            }

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }


        private void MarkUserAsAuthenticatedFromToken(string token)
        {
            var claims = ParseClaimsFromJwt(token);
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(authenticatedUser)));
        }



        public void MarkUserAsAuthenticated(string token)
        {
            var claims = ParseClaimsFromJwt(token);
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(authenticatedUser)));
        }


        public void MarkUserAsLoggedOut()
        {
            // Marque o usuário como desconectado (usuário anônimo)
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());

            // Notifique o provedor de estado de autenticação sobre a mudança
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymousUser)));
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


        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var parts = jwt.Split('.');

            if (parts.Length != 3)
            {
                Console.WriteLine("JWT inválido: não tem três partes.");
                return claims; // Retorna lista vazia se não for um JWT válido
            }

            var payload = parts[1];

            Console.WriteLine($"Payload: {payload}"); // Log do payload antes da decodificação

            var jsonBytes = ParseBase64WithoutPadding(payload);

            // Verifica se a decodificação do JSON é bem-sucedida
            try
            {
                var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
                if (keyValuePairs == null)
                {
                    Console.WriteLine("Falha na desserialização do payload JSON.");
                    return claims; // Retorna lista vazia se a desserialização falhar
                }

                // Processa roles
                keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

                if (roles != null)
                {
                    if (roles.ToString().Trim().StartsWith("["))
                    {
                        var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());
                        foreach (var parsedRole in parsedRoles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                        }
                    }
                    else
                    {
                        claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                    }
                    keyValuePairs.Remove(ClaimTypes.Role);
                }

                claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Erro ao desserializar o payload: {ex.Message}");
            }

            return claims;
        }


        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
