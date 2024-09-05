using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes.Architect;
using WebAthenPs.Project.Services.Interfaces.Professional;

namespace WebAthenPs.Project.Services.Implementation.Professional.ProfessionalTypes
{
    public class ArchitectService : IArchitectService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ArchitectService(IHttpClientFactory httpClientFactory,
            ILocalStorageService localStorage,
            AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClientFactory = httpClientFactory;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<GeneralArchitectDTO> CreateAsync(RegisterArchitectModel model)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");

                var modelAsJson = JsonSerializer.Serialize(model);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Architects", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var createdDto = JsonSerializer.Deserialize<GeneralArchitectDTO>(
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
                throw new Exception($"Error creating architect: {ex.Message}", ex);
            }
        }

        public async Task<GeneralArchitectDTO> GetByIdAsync(Guid id)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var authToken = await _localStorage.GetItemAsync<string>("authToken");
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("bearer", authToken);

                var response = await httpClient.GetAsync($"api/Architects/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var dto = JsonSerializer.Deserialize<GeneralArchitectDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dto;
                }
                return null;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception($"Error fetching architect by ID: {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<GeneralArchitectDTO>> GetAllAsync()
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var authToken = await _localStorage.GetItemAsync<string>("authToken");
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("bearer", authToken);

                var response = await httpClient.GetAsync("api/Architects");

                if (response.IsSuccessStatusCode)
                {
                    var dtoList = JsonSerializer.Deserialize<IEnumerable<GeneralArchitectDTO>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dtoList;
                }
                return Enumerable.Empty<GeneralArchitectDTO>();
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception($"Error fetching all architects: {ex.Message}", ex);
            }
        }

        public async Task UpdateAsync(Guid id, GeneralArchitectDTO model)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var authToken = await _localStorage.GetItemAsync<string>("authToken");
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("bearer", authToken);

                var modelAsJson = JsonSerializer.Serialize(model);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync($"api/Architects/{id}", requestContent);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error from server: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception($"Error updating architect: {ex.Message}", ex);
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var authToken = await _localStorage.GetItemAsync<string>("authToken");
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("bearer", authToken);

                var response = await httpClient.DeleteAsync($"api/Architects/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error from server: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception($"Error deleting architect: {ex.Message}", ex);
            }
        }
    }
}
