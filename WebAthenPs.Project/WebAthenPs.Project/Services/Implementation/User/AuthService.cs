using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using WebAthenPs.Models.DTOs.User;
using WebAthenPs.Project.Services.Interfaces.User;

public class AuthService : IAuthService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILocalStorageService _localStorage;
    private LoginResult _currentLoginResult;

    public AuthService(IHttpClientFactory httpClientFactory, ILocalStorageService localStorage)
    {
        _httpClientFactory = httpClientFactory;
        _localStorage = localStorage;
    }

    public async Task<LoginResult> Login(LoginModel loginModel)
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
                await _localStorage.SetItemAsync("userName", loginModel.Email);
                await _localStorage.SetItemAsync("userId", loginResult.UserId);

                _currentLoginResult = loginResult; // Armazenar o resultado do login
                return loginResult;
            }
        }

        return new LoginResult { Token = string.Empty };
    }

    public async Task Logout()
    {
        await _localStorage.RemoveItemAsync("authToken");
        await _localStorage.RemoveItemAsync("tokenExpiration");
        await _localStorage.RemoveItemAsync("userName");
        await _localStorage.RemoveItemAsync("userId");
        _currentLoginResult = null; // Limpar o resultado do login
    }

    public async Task<string?> Register(RegisterModel registerModel)
    {
        var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
        var registerAsJson = JsonSerializer.Serialize(registerModel);
        var requestContent = new StringContent(registerAsJson, Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync("api/Users/Register", requestContent);

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            var registerResult = JsonSerializer.Deserialize<RegisterResult>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            // Limpar o LocalStorage após o registro
            await _localStorage.RemoveItemAsync("authToken");
            await _localStorage.RemoveItemAsync("tokenExpiration");
            await _localStorage.RemoveItemAsync("userName");
            await _localStorage.RemoveItemAsync("userId");

            return registerResult?.UserId;
        }

        return null;
    }


    public async Task<LoginResult> GetLoginResultAsync()
    {
        return _currentLoginResult; // Retorna o resultado do login atual
    }
}
