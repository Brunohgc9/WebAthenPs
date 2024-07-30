using WebAthenPs.Models.DTOs;
using WebAthenPs.Project.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Blazored.LocalStorage;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class GenericProfessionalService : IGenericProfessionalService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<GenericProfessionalService> _logger;
        private readonly ILocalStorageService _localStorage;

        public GenericProfessionalService(HttpClient httpClient, ILogger<GenericProfessionalService> logger, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _logger = logger;
            _localStorage = localStorage;
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

                var professionalsDto = await _httpClient.GetFromJsonAsync<IEnumerable<GProfessionalDTO>>("api/GenericProfessionals");
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

                var professionalDto = await _httpClient.GetFromJsonAsync<GProfessionalDTO>($"api/GenericProfessionals/{id}");
                if (professionalDto == null)
                {
                    _logger.LogWarning($"Profissional com ID {id} não encontrado.");
                }
                return professionalDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais para ID {id}. URL: api/GenericProfessionals/{id}");
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
                var professionalsDto = await _httpClient.GetFromJsonAsync<IEnumerable<GProfessionalDTO>>($"api/GenericProfessionals/name/{name}");
                if (professionalsDto == null)
                {
                    _logger.LogWarning($"Nenhum profissional encontrado com o nome {name}.");
                }
                return professionalsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais com o nome {name}. URL: api/GenericProfessionals/name/{name}");
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
                var professionalsDto = await _httpClient.GetFromJsonAsync<IEnumerable<GProfessionalDTO>>($"api/GenericProfessionals/type/{professionalType}");
                if (professionalsDto == null)
                {
                    _logger.LogWarning($"Nenhum profissional encontrado com o tipo {professionalType}.");
                }
                return professionalsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais com o tipo {professionalType}. URL: api/GenericProfessionals/type/{professionalType}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais com o tipo {professionalType}.");
                throw;
            }
        }
    }
}
