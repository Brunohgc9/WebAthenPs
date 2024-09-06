using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using Blazored.LocalStorage;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Authorization;
using WebAthenPs.Models.DTOs.Project;
using WebAthenPs.Project.Services.Interfaces.Project;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.Project.Services.Implementation.Project
{
    public class ProjectService : IProjectService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ProjectService> _logger;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ProjectService(IHttpClientFactory httpClientFactory, ILogger<ProjectService> logger, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        private async Task<HttpClient> CreateAuthorizedClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var token = await _localStorage.GetItemAsync<string>("authToken");

            if (!string.IsNullOrEmpty(token))
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            return httpClient;
        }

        public async Task<IEnumerable<ProjectsDTO>> GetAll()
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var projectsDto = await httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>("api/Projects");

                if (projectsDto == null)
                {
                    _logger.LogWarning("Nenhum projeto encontrado na API em 'api/Projects'.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API de projetos. URL: api/Projects");
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
                var httpClient = await CreateAuthorizedClientAsync();
                var projectDto = await httpClient.GetFromJsonAsync<ProjectsDTO>($"api/Projects/id/{id}");

                if (projectDto == null)
                {
                    _logger.LogWarning($"Projeto com ID {id} não encontrado.");
                }
                return projectDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de projetos para ID {id}. URL: api/Projects/{id}");
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
                var httpClient = await CreateAuthorizedClientAsync();
                var projectsDto = await httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>($"api/Projects/status/{status}");

                if (projectsDto == null)
                {
                    _logger.LogWarning($"Nenhum projeto encontrado com o status {status}.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de projetos com o status {status}. URL: api/Projects/status/{status}");
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
                var httpClient = await CreateAuthorizedClientAsync();
                var projectsDto = await httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>($"api/Projects/area/{area}");

                if (projectsDto == null)
                {
                    _logger.LogWarning($"Nenhum projeto encontrado com a área {area}.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de projetos com a área {area}. URL: api/Projects/area/{area}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de projetos com a área {area}.");
                throw;
            }
        }

        public async Task<ProjectsDTO> CreateProject(RegisterProjectModel model)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PostAsJsonAsync("api/Projects", model);

                if (response.IsSuccessStatusCode)
                {
                    var createdProject = await response.Content.ReadFromJsonAsync<ProjectsDTO>();
                    _logger.LogInformation("Projeto criado com sucesso.");
                    return createdProject;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao criar o projeto. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para criar um projeto.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao criar um projeto.");
                throw;
            }
        }


        public async Task DeleteProject(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Projects/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Erro ao deletar o projeto com ID {id}. StatusCode: {response.StatusCode}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para deletar o projeto com ID {id}. URL: api/Projects/{id}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao deletar o projeto com ID {id}.");
                throw;
            }
        }

        public async Task<IEnumerable<ProjectsDTO>> GetProjectsByLoggedInUser()
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var projectsDto = await httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>("api/Projects/clientProjects");

                if (projectsDto == null)
                {
                    _logger.LogWarning("Nenhum projeto encontrado para o cliente logado.");
                }
                return projectsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API de projetos para o cliente logado.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao acessar a API de projetos para o cliente logado.");
                throw;
            }
        }

        public async Task<ProjectsDTO> UpdateProject(int id, ProjectsDTO dto)
        {
            // Valide o DTO antes de enviar para a API
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "O DTO do projeto não pode ser nulo.");
            }

            if (dto.ProjectProfessionals != null)
            {
                foreach (var projectProfessional in dto.ProjectProfessionals)
                {
                    // Verifique se o campo Professional está nulo e se foi corretamente preenchido
                    if (projectProfessional.Professional == null)
                    {
                        throw new ArgumentException("O campo Professional não pode ser nulo.");
                    }
                }
            }

            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsJsonAsync($"api/Projects/{id}", dto);

                if (response.IsSuccessStatusCode)
                {
                    var updatedProject = await response.Content.ReadFromJsonAsync<ProjectsDTO>();
                    _logger.LogInformation("Projeto atualizado com sucesso.");
                    return updatedProject;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao atualizar o projeto. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para atualizar um projeto.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao atualizar um projeto.");
                throw;
            }
        }





    }
}
