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
using WebAthenPs.Project.Services.Interfaces.User;
using WebAthenPs.Models.DTOs.Components;
using Newtonsoft.Json.Linq;
using WebAthenPs.Project.Services.Interfaces.Professional;
using WebAthenPs.Models.DTOs.Components.Chats;

namespace WebAthenPs.Project.Services.Implementation.Project
{
    public class ProjectService : IProjectService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ProjectService> _logger;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IAuthService _authService;
        private readonly SignalRConnection _signalRConnection;
        private readonly IGenericProfessionalService _genericProfessionalService;

        public ProjectService(IHttpClientFactory httpClientFactory, ILogger<ProjectService> logger, AuthenticationStateProvider authenticationStateProvider, IAuthService authService, SignalRConnection signalRConnection, IGenericProfessionalService genericProfessionalService)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _authenticationStateProvider = authenticationStateProvider;
            _authService = authService;
            _signalRConnection = signalRConnection;
            _genericProfessionalService = genericProfessionalService;
        }

        private async Task<HttpClient> CreateAuthorizedClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");

            // Verifica se o usuário está logado
            if (!await _authService.IsLoggedIn())
            {
                _logger.LogWarning("Usuário não está logado.");
                throw new UnauthorizedAccessException("Usuário não está logado."); // Ou trate como preferir
            }

            var token = await _authService.GetToken(); // Obtém o token descriptografado

            if (!string.IsNullOrEmpty(token))
            {
                _logger.LogInformation($"Token: {token}");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                _logger.LogWarning("Token não encontrado ou está vazio.");
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
            // Validação do DTO
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "O DTO do projeto não pode ser nulo.");
            }

            // Verificar e manipular a lista de profissionais do projeto
            if (dto.ProjectProfessionals != null)
            {
                foreach (var projectProfessional in dto.ProjectProfessionals)
                {
                    // Verificar se o campo Professional está preenchido
                    if (projectProfessional.Professional == null)
                    {
                        _logger.LogWarning("O campo Professional está nulo, ignorando...");
                        continue; // Ignora o Professional nulo
                    }

                    // Você pode adicionar outras validações aqui, se necessário
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


        public async Task<bool> AddProfessional(ProjectProfessionalDTO projectProfessionalDTO, ProposalDTO proposal)
        {
            // Validação do DTO do profissional
            if (projectProfessionalDTO == null || projectProfessionalDTO.ProfessionalId <= 0 || projectProfessionalDTO.ProjectId <= 0)
            {
                throw new ArgumentException("O DTO do profissional é inválido.", nameof(projectProfessionalDTO));
            }

            // Verifica se a proposta foi aceita
            if (!proposal.IsAccepted)
            {
                _logger.LogInformation($"Profissional com ID {projectProfessionalDTO.ProfessionalId} não pode ser adicionado ao projeto com ID {projectProfessionalDTO.ProjectId} porque a proposta foi recusada.");
                return false; // Não registra, pois a proposta não foi aceita
            }

            try
            {
                // 1. Adiciona o profissional ao projeto
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PostAsJsonAsync($"api/Projects/{projectProfessionalDTO.ProjectId}/professionals", projectProfessionalDTO);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao adicionar o profissional ao projeto. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                    return false;
                }

                // 2. Após adicionar ao projeto, obtemos o UserId do profissional
                var professionalUser = await _genericProfessionalService.GetByIdAsync(projectProfessionalDTO.ProfessionalId);
                if (professionalUser == null || string.IsNullOrEmpty(professionalUser.UserId))
                {
                    _logger.LogWarning($"Profissional com ID {projectProfessionalDTO.ProfessionalId} não tem um UserId válido.");
                    return false;
                }

                string userId = professionalUser.UserId; // Obtém o UserId do profissional

                // 3. Obtemos o chatId associado ao projeto
                Guid chatId = await GetChatIdByProjectIdAsync(projectProfessionalDTO.ProjectId);

                if (chatId == Guid.Empty)
                {
                    _logger.LogWarning($"ChatId não encontrado para o projeto com ID {projectProfessionalDTO.ProjectId}.");
                    return false;
                }

                // 4. Adiciona o profissional ao chat do projeto
                await _signalRConnection.AddUserToChat(chatId, userId);
                _logger.LogInformation($"Profissional com ID {projectProfessionalDTO.ProfessionalId} adicionado ao chat do projeto com ID {projectProfessionalDTO.ProjectId} com sucesso.");

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao adicionar o profissional ao projeto e chat do projeto com ID {projectProfessionalDTO.ProjectId}.");
                throw;
            }
        }


        public async Task<Guid> GetChatIdByProjectIdAsync(int projectId)
        {
            try
            {
                // Criação do cliente HTTP autorizado
                var httpClient = await CreateAuthorizedClientAsync();

                // Faz a chamada para obter o chat associado ao projeto (geral ou individual)
                var chatResponse = await httpClient.GetFromJsonAsync<ChatDto>($"api/Projects/{projectId}/chat");

                // Verifica se o chat não foi encontrado ou o ID é inválido
                if (chatResponse == null || chatResponse.Id == Guid.Empty)
                {
                    _logger.LogWarning($"Chat não encontrado para o projeto com ID {projectId}.");
                    return Guid.Empty; // Retorna Guid.Empty se não encontrar o chat
                }

                // Se encontrado, loga a informação e retorna o ID do chat
                _logger.LogInformation($"Chat encontrado: ID {chatResponse.Id} para o projeto {projectId}.");
                return chatResponse.Id;
            }
            catch (HttpRequestException httpEx)
            {
                // Caso ocorra um erro de comunicação com o serviço
                _logger.LogError(httpEx, $"Erro de comunicação ao buscar o ChatId para o projeto com ID {projectId}.");
                throw;
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro inesperado
                _logger.LogError(ex, $"Erro inesperado ao buscar o ChatId para o projeto com ID {projectId}.");
                throw;
            }
        }

        public async Task<List<ChatDto>> GetChatsByProjectIdAsync(int projectId)
        {
            try
            {
                // Criação do cliente HTTP autorizado
                var httpClient = await CreateAuthorizedClientAsync();

                // Faz a chamada para obter os chats associados ao projeto
                var chatsResponse = await httpClient.GetFromJsonAsync<List<ChatDto>>($"api/Projects/{projectId}/chats");

                // Verifica se os chats não foram encontrados
                if (chatsResponse == null || !chatsResponse.Any())
                {
                    _logger.LogWarning($"Chats não encontrados para o projeto com ID {projectId}.");
                    return new List<ChatDto>(); // Retorna uma lista vazia se não encontrar os chats
                }

                return chatsResponse;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro de comunicação ao buscar chats para o projeto com ID {projectId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao buscar chats para o projeto com ID {projectId}.");
                throw;
            }
        }


        public async Task<IEnumerable<GenericProfessionalDTO>> GetProfessionalsByProject(int projectId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var professionalsDto = await httpClient.GetFromJsonAsync<IEnumerable<GenericProfessionalDTO>>($"api/Projects/{projectId}/professionals");

                if (professionalsDto == null || !professionalsDto.Any())
                {
                    _logger.LogWarning($"Nenhum profissional encontrado para o projeto com ID {projectId}.");
                }
                return professionalsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para obter os profissionais do projeto com ID {projectId}. URL: api/Projects/{projectId}/professionals");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API para obter os profissionais do projeto com ID {projectId}.");
                throw;
            }
        }

        public async Task<ChatDto> GetChatByProjectIdAsync(int projectId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();

                // Faz a chamada para o endpoint da API
                var chatResponse = await httpClient.GetFromJsonAsync<ChatDto>($"api/Projects/{projectId}/chat");

                if (chatResponse == null)
                {
                    _logger.LogWarning($"Chat não encontrado para o projeto com ID {projectId}.");
                    return null;
                }

                return chatResponse;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro de comunicação ao buscar o Chat para o projeto com ID {projectId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao buscar o Chat para o projeto com ID {projectId}.");
                throw;
            }
        }

        public async Task<List<ChatDto>> GetIndividualChatsByProjectIdAsync(int projectId)
        {
            try
            {
                // Criação do cliente HTTP autorizado
                var httpClient = await CreateAuthorizedClientAsync();

                // Chamada para o endpoint da API que retorna os chats individuais
                var response = await httpClient.GetFromJsonAsync<List<ChatDto>>($"api/Projects/{projectId}/individual-chats");

                // Verifica se a resposta contém chats
                if (response == null || !response.Any())
                {
                    _logger.LogWarning($"Nenhum chat individual encontrado para o projeto com ID {projectId}.");
                    return new List<ChatDto>(); // Retorna uma lista vazia
                }

                return response; // Retorna a lista de chats individuais
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para obter chats individuais para o projeto com ID {projectId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao buscar chats individuais para o projeto com ID {projectId}.");
                throw;
            }
        }

    }
}
