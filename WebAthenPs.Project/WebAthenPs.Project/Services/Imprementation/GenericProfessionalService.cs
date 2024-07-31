using WebAthenPs.Models.DTOs;
using WebAthenPs.Project.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Blazored.LocalStorage;
using System.Text.Json;
using System.Text;
using System.Net;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class GenericProfessionalService : IGenericProfessionalService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;
        private readonly HttpClient _httpClient;
        private readonly ILogger<GenericProfessionalService> _logger;
        private readonly ILocalStorageService _localStorage;
        private const string apiEndpoint = "api/GenericProfessionals/";

        public GenericProfessionalService(IHttpClientFactory httpClientFactory, JsonSerializerOptions options, ILogger<GenericProfessionalService> logger, ILocalStorageService localStorage)
        {
            _httpClientFactory = httpClientFactory;
            _options = options;
            _logger = logger;
            _localStorage = localStorage;
            _httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
        }

        public async Task<bool> CreateProfessional(GProfessionalDTO professionalDTO)
        {
            try
            {
                StringContent content = new StringContent(JsonSerializer.Serialize(professionalDTO),
                                                          Encoding.UTF8, "application/json");

                using (var response = await _httpClient.PostAsync(apiEndpoint + "CreateP", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        throw new UnauthorizedAccessException();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar profissional.");
                return false;
            }
        }



        public async Task<bool> DeleteProfessional(int id)
        {
            using (var response = await _httpClient.DeleteAsync(apiEndpoint + id))
            {
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException();
                }
            }
            return false;
        }

        public async Task<IEnumerable<GProfessionalDTO>> GetAll()
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                var professionalsDto = await _httpClient.GetFromJsonAsync<IEnumerable<GProfessionalDTO>>(apiEndpoint);
                if (professionalsDto == null)
                {
                    _logger.LogWarning("Nenhum profissional encontrado na API em 'api/GenericProfessionals'.");
                }
                return professionalsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API de profissionais. URL: api/GenericProfessionals");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao acessar a API de profissionais.");
                throw;
            }
        }

        public async Task<GProfessionalDTO> GetById(int id)
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                var professionalDto = await _httpClient.GetFromJsonAsync<GProfessionalDTO>($"{apiEndpoint}{id}");
                if (professionalDto == null)
                {
                    _logger.LogWarning($"Profissional com ID {id} não encontrado.");
                }
                return professionalDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais para ID {id}. URL: {apiEndpoint}{id}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais para ID {id}.");
                throw;
            }
        }

        public async Task<IEnumerable<GProfessionalDTO>> GetByName(string name)
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var professionalsDto = await _httpClient.GetFromJsonAsync<IEnumerable<GProfessionalDTO>>($"{apiEndpoint}ByName/{name}");
                if (professionalsDto == null)
                {
                    _logger.LogWarning($"Nenhum profissional encontrado com o nome {name}.");
                }
                return professionalsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais com o nome {name}. URL: {apiEndpoint}ByName/{name}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais com o nome {name}.");
                throw;
            }
        }

        public async Task<IEnumerable<GProfessionalDTO>> GetByProfessionalType(string professionalType)
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var professionalsDto = await _httpClient.GetFromJsonAsync<IEnumerable<GProfessionalDTO>>($"{apiEndpoint}ByProfessionalType/{professionalType}");
                if (professionalsDto == null)
                {
                    _logger.LogWarning($"Nenhum profissional encontrado com o tipo {professionalType}.");
                }
                return professionalsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais com o tipo {professionalType}. URL: {apiEndpoint}ByProfessionalType/{professionalType}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais com o tipo {professionalType}.");
                throw;
            }
        }

        public async Task<GProfessionalDTO> UpdateProfessional(GProfessionalDTO professionalDTO, int id)
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            GProfessionalDTO ProfessionalUpdated = new GProfessionalDTO();
            using (var response = await httpClient.PutAsJsonAsync(apiEndpoint + id, professionalDTO))
            {
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsStreamAsync();
                    ProfessionalUpdated = await JsonSerializer
                                        .DeserializeAsync<GProfessionalDTO>(apiResponse, _options);
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException();
                }
            }
            return ProfessionalUpdated;
        }
    }
}
