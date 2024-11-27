﻿using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Models.DTOs.Components.Chats;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;

namespace WebAthenPs.Project.Services.Interfaces.Project
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectsDTO>> GetAll();
        Task<ProjectsDTO> GetById(int id);
        Task<IEnumerable<ProjectsDTO>> GetByStatus(string status);
        Task<IEnumerable<ProjectsDTO>> GetByArea(decimal area);
        Task<ProjectsDTO> CreateProject(RegisterProjectModel model);
        Task DeleteProject(int id);
        Task<IEnumerable<ProjectsDTO>> GetProjectsByLoggedInUser();
        Task<ProjectsDTO> UpdateProject(int id, ProjectsDTO dto);
        Task<bool> AddProfessional(ProjectProfessionalDTO projectProfessionalDTO, ProposalDTO proposal);
        Task<IEnumerable<GenericProfessionalDTO>> GetProfessionalsByProject(int projectId);
        Task<Guid> GetChatIdByProjectIdAsync(int projectId);
        Task<List<ChatDto>> GetChatsByProjectIdAsync(int projectId);
        Task<List<ChatDto>> GetIndividualChatsByProjectIdAsync(int projectId);
    }
}