using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using WebAthenPs.API.Services.Interfaces;
using WebAthenPs.Models.DTOs;
using WebAthenPs.Models.Models;

public class GenericProfessionalService : IGenericProfessionalService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILocalStorageService _localStorage;
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public GenericProfessionalService(IHttpClientFactory httpClientFactory,
        ILocalStorageService localStorage,
        AuthenticationStateProvider authenticationStateProvider)
    {
        _httpClientFactory = httpClientFactory;
        _localStorage = localStorage;
        _authenticationStateProvider = authenticationStateProvider;
    }

    public async Task<GenericProfessionalDTO> CreateAsync(RegisterProfessionalModel model, string userId)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");


            var modelAsJson = JsonSerializer.Serialize(model);
            var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/GenericProfessional", requestContent);

            if (response.IsSuccessStatusCode)
            {
                var createdDto = JsonSerializer.Deserialize<GenericProfessionalDTO>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return createdDto;
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error from server: {errorMessage}");
            }
        }
        catch (Exception ex)
        {
            // Log or handle the exception as needed
            throw new Exception($"Error creating professional: {ex.Message}", ex);
        }
    }


    public async Task<GenericProfessionalDTO> GetByIdAsync(int id)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var authToken = await _localStorage.GetItemAsync<string>("authToken");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", authToken);

            var response = await httpClient.GetAsync($"api/GenericProfessional/{id}");

            if (response.IsSuccessStatusCode)
            {
                var dto = JsonSerializer.Deserialize<GenericProfessionalDTO>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return dto;
            }
            return null;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<GenericProfessionalDTO>> GetAllAsync(string professionalType)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var authToken = await _localStorage.GetItemAsync<string>("authToken");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", authToken);

            var url = "api/GenericProfessional";
            if (!string.IsNullOrEmpty(professionalType))
            {
                url += $"?professionalType={professionalType}";
            }

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var dtoList = JsonSerializer.Deserialize<IEnumerable<GenericProfessionalDTO>>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return dtoList;
            }
            return Enumerable.Empty<GenericProfessionalDTO>();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<GenericProfessionalDTO>> GetByProfessionalTypeAsync(string professionalType)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var authToken = await _localStorage.GetItemAsync<string>("authToken");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", authToken);

            var response = await httpClient.GetAsync($"api/GenericProfessional?professionalType={professionalType}");

            if (response.IsSuccessStatusCode)
            {
                var dtoList = JsonSerializer.Deserialize<IEnumerable<GenericProfessionalDTO>>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return dtoList;
            }
            return Enumerable.Empty<GenericProfessionalDTO>();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<GenericProfessionalDTO> UpdateAsync(int id, RegisterProfessionalModel model)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var authToken = await _localStorage.GetItemAsync<string>("authToken");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", authToken);

            var modelAsJson = JsonSerializer.Serialize(model);
            var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync($"api/GenericProfessional/{id}", requestContent);

            if (response.IsSuccessStatusCode)
            {
                var updatedDto = JsonSerializer.Deserialize<GenericProfessionalDTO>(
                    await response.Content.ReadAsStringAsync(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return updatedDto;
            }
            return null;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task DeleteAsync(int id)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var authToken = await _localStorage.GetItemAsync<string>("authToken");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", authToken);

            var response = await httpClient.DeleteAsync($"api/GenericProfessional/{id}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error deleting the professional.");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}
