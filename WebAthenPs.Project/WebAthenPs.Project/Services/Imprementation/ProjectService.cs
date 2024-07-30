using WebAthenPs.Models.DTOs;
using WebAthenPs.Project.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProjectService> _logger;
        private readonly ILocalStorageService _localStorage;

        public ProjectService(HttpClient httpClient, ILogger<ProjectService> logger, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _logger = logger;
            _localStorage = localStorage;
        }

        public async Task<IEnumerable<ProjectsDTO>> GetAll()
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var projectsDto = await _httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>("api/Projects");
                if (projectsDto == null)
                {
                    _logger.LogWarning("Nenhum projeto encontrado na API em 'api/projects'.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API de projetos. URL: api/projects");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao acessar a API de projetos.");
                throw;
            }
        }

        public async Task<ProjectsDTO> GetById(int id)
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var projectDto = await _httpClient.GetFromJsonAsync<ProjectsDTO>($"api/Projects/id/{id}");
                if (projectDto == null)
                {
                    _logger.LogWarning($"Projeto com ID {id} não encontrado.");
                }
                return projectDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de projetos para ID {id}. URL: api/projects/id/{id}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de projetos para ID {id}.");
                throw;
            }
        }

        public async Task<IEnumerable<ProjectsDTO>> GetByStatus(string status)
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var projectsDto = await _httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>($"api/Projects/status/{status}");
                if (projectsDto == null)
                {
                    _logger.LogWarning($"Nenhum projeto encontrado com o status {status}.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de projetos com o status {status}. URL: api/projects/status/{status}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de projetos com o status {status}.");
                throw;
            }
        }

        public async Task<IEnumerable<ProjectsDTO>> GetByArea(decimal area)
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var projectsDto = await _httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>($"api/Projects/areaquadrada/{area}");
                if (projectsDto == null)
                {
                    _logger.LogWarning($"Nenhum projeto encontrado com a área {area}.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de projetos com a área {area}. URL: api/projects/areaquadrada/{area}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de projetos com a área {area}.");
                throw;
            }
        }
    }
}
