using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Data;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation;
using WebAthenPs.Models.DTOs.Project.Steps;
using WebAthenPs.API.Entities.Project.Steps;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
{
    public static class MappingProjectDTO
    {
        public static IEnumerable<ProjectsDTO> ConverterProjetosParaDTO(this IEnumerable<Projecty> projects)
        {
            return projects?.Select(item => new ProjectsDTO
            {
                ProjectId = item.ProjectId,
                ProjectName = item.ProjectName,
                ConstructionType = item.ConstructionType,
                Status = item.Status,
                Budget = item.Budget,
                StartDate = item.StartDate,
                EndDate = item.EndDate,
                Description = item.Description,
                ClientId = item.Client?.ClientId ?? default,
                ClientName = item.Client?.User?.UserName ?? string.Empty,
                Address = item.Address,
                Neighborhood = item.Neighborhood,
                City = item.City,
                State = item.State,
                PostalCode = item.PostalCode,
                Country = item.Country,
                TotalArea = item.TotalArea,
                NumberOfRooms = item.NumberOfRooms,
                ActStep = item.ActStep,
                NumberOfBathrooms = item.NumberOfBathrooms,
                ProjectSteps = new ProjectStepsDto
                {
                    Id = item.ProjectSteps?.Id ?? Guid.Empty,
                    ProjectId = item.ProjectSteps?.ProjectId ?? default,

                    // Mapeamento das etapas do projeto com os respectivos IDs
                    Step1HireArchitectId = item.ProjectSteps?.Step1HireArchitectId,
                    Step2ProjectId = item.ProjectSteps?.Step2ProjectId,
                    Step3ApprovalInCityHallId = item.ProjectSteps?.Step3ApprovalInCityHallId,
                    Step4ComplementaryProjectsId = item.ProjectSteps?.Step4ComplementaryProjectsId,
                    Step5BudgetSheetId = item.ProjectSteps?.Step5BudgetSheetId,
                    Step6ConstructionPlanningId = item.ProjectSteps?.Step6ConstructionPlanningId,
                    Step7PreliminaryServicesId = item.ProjectSteps?.Step7PreliminaryServicesId,
                    Step8ConstructionLocationId = item.ProjectSteps?.Step8ConstructionLocationId,
                    Step9StructuralProjectId = item.ProjectSteps?.Step9StructuralProjectId,
                    Step10MasonryId = item.ProjectSteps?.Step10MasonryId,
                    Step11RoofingId = item.ProjectSteps?.Step11RoofingId,
                    Step12SanitaryInstallationsId = item.ProjectSteps?.Step12SanitaryInstallationsId,
                    Step13ElectricalInstallationsId = item.ProjectSteps?.Step13ElectricalInstallationsId,
                    Step14ComplementaryInstallationsId = item.ProjectSteps?.Step14ComplementaryInstallationsId,
                    Step15FinishesId = item.ProjectSteps?.Step15FinishesId,
                    Step16DoorsAndWindowsId = item.ProjectSteps?.Step16DoorsAndWindowsId,
                    Step17CeilingsAndFinishesId = item.ProjectSteps?.Step17CeilingsAndFinishesId,
                    Step18MarbleworkId = item.ProjectSteps?.Step18MarbleworkId,
                    Step19LightingId = item.ProjectSteps?.Step19LightingId,
                    Step20FloorsId = item.ProjectSteps?.Step20FloorsId,
                    Step21CarpentryWashbasinsAndMetalsId = item.ProjectSteps?.Step21CarpentryWashbasinsAndMetalsId,
                    Step22PaintingId = item.ProjectSteps?.Step22PaintingId,
                    Step23LandscapingId = item.ProjectSteps?.Step23LandscapingId,
                    Step24CleaningOfTheSiteId = item.ProjectSteps?.Step24CleaningOfTheSiteId,
                    Step25DecorationId = item.ProjectSteps?.Step25DecorationId
                },
                LProfessionals = item.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    UserName = p.User?.UserName ?? string.Empty,
                    PhoneNumber = p.User?.PhoneNumber,
                    Email = p.User?.Email,
                    ProfessionalTypes = p.ProfessionalTypes,
                    GenericProfessionalTypeDTO = p.GenericProfessionalType != null ? new GenericProfessionalProfessionalTypeDTO
                    {
                        Id = p.GenericProfessionalType.Id,
                    } : null,
                    //GeneralArchitect = p.Architect != null ? new GeneralArchitectDTO
                    //{
                    //    genericId = p.Id, // Corrigido para corresponder à propriedade correta
                    //    ArchId = p.Architect.ArchId,
                    //    RegistroConselho = p.Architect.RegistroConselho,
                    //    Especialidade = p.Architect.Especialidade
                    //} : null
                }).ToList() ?? new List<GenericProfessionalDTO>(),
                ProjectProfessionals = item.ProjectProfessionals?.Select(pp => new ProjectProfessionalDTO
                {
                    ProfessionalId = pp.ProfessionalId,
                    ProjectId = pp.ProjectId,
                    Salary = pp.Salary,
                    Professional = pp.Professional != null ? new GenericProfessionalDTO
                    {
                        Id = pp.Professional.Id,
                        UserId = pp.Professional.UserId,
                        UserName = pp.Professional.User?.UserName ?? string.Empty,
                        PhoneNumber = pp.Professional.User?.PhoneNumber,
                        Email = pp.Professional.User?.Email,
                        ProfessionalTypes = pp.Professional.ProfessionalTypes,
                        //GeneralArchitect = pp.Professional.Architect != null ? new GeneralArchitectDTO
                        //{
                        //    genericId = pp.Professional.Id,
                        //    ArchId = pp.Professional.Architect.ArchId,
                        //    RegistroConselho = pp.Professional.Architect.RegistroConselho,
                        //    Especialidade = pp.Professional.Architect.Especialidade
                        //} : null
                    } : null
                }).ToList() ?? new List<ProjectProfessionalDTO>(),
                ProjectProposals = item.ProjectProposals?.Select(proposal => new ProposalDTO
                {
                    ProposalId = proposal.ProposalId,
                    ProposalMessage = proposal.ProposalMessage ?? string.Empty,
                    ProposalValue = proposal.ProposalValue,
                    ProposalType = proposal.ProposalType ?? string.Empty,
                    IsAccepted = proposal.IsAccepted,
                    Client = proposal.Client != null ? new ClientDTO
                    {
                        ClientId = proposal.Client.ClientId,
                        UserId = proposal.Client.UserId,
                        UserName = proposal.Client.User?.UserName ?? string.Empty,
                        Email = proposal.Client.User?.Email ?? string.Empty,
                    } : null,
                    Professional = proposal.Professional != null ? new GenericProfessionalDTO
                    {
                        Id = proposal.Professional.Id,
                        UserId = proposal.Professional.UserId,
                        UserName = proposal.Professional.User?.UserName ?? string.Empty,
                        Email = proposal.Professional.User?.Email ?? string.Empty,
                    } : null
                }).ToList() ?? new List<ProposalDTO>()
            }) ?? Enumerable.Empty<ProjectsDTO>();
        }

        public static ProjectsDTO ConverterProjetoParaDTO(this Projecty project)
        {
            return new ProjectsDTO
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName ?? string.Empty,
                ConstructionType = project.ConstructionType ?? string.Empty,
                Status = project.Status ?? string.Empty,
                Budget = project.Budget,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Description = project.Description ?? string.Empty,
                ClientId = project.Client?.ClientId ?? default,
                ClientName = project.Client?.User?.UserName ?? string.Empty,
                Address = project.Address ?? string.Empty,
                Neighborhood = project.Neighborhood ?? string.Empty,
                City = project.City ?? string.Empty,
                State = project.State ?? string.Empty,
                PostalCode = project.PostalCode ?? string.Empty,
                Country = project.Country ?? string.Empty,
                TotalArea = project.TotalArea,
                NumberOfRooms = project.NumberOfRooms,
                NumberOfBathrooms = project.NumberOfBathrooms,
                ActStep = project.ActStep ?? string.Empty,
                ProjectSteps = new ProjectStepsDto
                {
                    Id = project.ProjectSteps?.Id ?? Guid.Empty,
                    ProjectId = project.ProjectSteps?.ProjectId ?? default,

                    // Mapeamento das etapas do projeto com os respectivos IDs
                    Step1HireArchitectId = project.ProjectSteps?.Step1HireArchitectId,
                    Step2ProjectId = project.ProjectSteps?.Step2ProjectId,
                    Step3ApprovalInCityHallId = project.ProjectSteps?.Step3ApprovalInCityHallId,
                    Step4ComplementaryProjectsId = project.ProjectSteps?.Step4ComplementaryProjectsId,
                    Step5BudgetSheetId = project.ProjectSteps?.Step5BudgetSheetId,
                    Step6ConstructionPlanningId = project.ProjectSteps?.Step6ConstructionPlanningId,
                    Step7PreliminaryServicesId = project.ProjectSteps?.Step7PreliminaryServicesId,
                    Step8ConstructionLocationId = project.ProjectSteps?.Step8ConstructionLocationId,
                    Step9StructuralProjectId = project.ProjectSteps?.Step9StructuralProjectId,
                    Step10MasonryId = project.ProjectSteps?.Step10MasonryId,
                    Step11RoofingId = project.ProjectSteps?.Step11RoofingId,
                    Step12SanitaryInstallationsId = project.ProjectSteps?.Step12SanitaryInstallationsId,
                    Step13ElectricalInstallationsId = project.ProjectSteps?.Step13ElectricalInstallationsId,
                    Step14ComplementaryInstallationsId = project.ProjectSteps?.Step14ComplementaryInstallationsId,
                    Step15FinishesId = project.ProjectSteps?.Step15FinishesId,
                    Step16DoorsAndWindowsId = project.ProjectSteps?.Step16DoorsAndWindowsId,
                    Step17CeilingsAndFinishesId = project.ProjectSteps?.Step17CeilingsAndFinishesId,
                    Step18MarbleworkId = project.ProjectSteps?.Step18MarbleworkId,
                    Step19LightingId = project.ProjectSteps?.Step19LightingId,
                    Step20FloorsId = project.ProjectSteps?.Step20FloorsId,
                    Step21CarpentryWashbasinsAndMetalsId = project.ProjectSteps?.Step21CarpentryWashbasinsAndMetalsId,
                    Step22PaintingId = project.ProjectSteps?.Step22PaintingId,
                    Step23LandscapingId = project.ProjectSteps?.Step23LandscapingId,
                    Step24CleaningOfTheSiteId = project.ProjectSteps?.Step24CleaningOfTheSiteId,
                    Step25DecorationId = project.ProjectSteps?.Step25DecorationId
                },
                LProfessionals = project.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    UserName = p.User?.UserName ?? string.Empty,
                    PhoneNumber = p.User?.PhoneNumber,
                    Email = p.User?.Email,
                    ProfessionalTypes = p.ProfessionalTypes ?? new List<string>(),
                    //GeneralArchitect = p.Architect != null ? new GeneralArchitectDTO
                    //{
                    //    genericId = p.Id,
                    //    ArchId = p.Architect.ArchId,
                    //    RegistroConselho = p.Architect.RegistroConselho,
                    //    Especialidade = p.Architect.Especialidade
                    //} : null
                }).ToList() ?? new List<GenericProfessionalDTO>(),

                ProjectProfessionals = project.ProjectProfessionals?.Select(pp => new ProjectProfessionalDTO
                {
                    ProfessionalId = pp.ProfessionalId,
                    ProjectId = pp.ProjectId,
                    Salary = pp.Salary,
                    Professional = pp.Professional != null ? new GenericProfessionalDTO
                    {
                        Id = pp.Professional.Id,
                        UserId = pp.Professional.UserId,
                        UserName = pp.Professional.User?.UserName ?? string.Empty,
                        PhoneNumber = pp.Professional.User?.PhoneNumber,
                        Email = pp.Professional.User?.Email,
                        ProfessionalTypes = pp.Professional.ProfessionalTypes ?? new List<string>(),
                        GenericProfessionalTypeDTO = pp.Professional.GenericProfessionalType != null ? new GenericProfessionalProfessionalTypeDTO
                        {
                            Id = pp.Professional.GenericProfessionalType.Id,
                        } : null,
                        //GeneralArchitect = pp.Professional.Architect != null ? new GeneralArchitectDTO
                        //{
                        //    genericId = pp.Professional.Id,
                        //    ArchId = pp.Professional.Architect.ArchId,
                        //    RegistroConselho = pp.Professional.Architect.RegistroConselho,
                        //    Especialidade = pp.Professional.Architect.Especialidade
                        //} : null
                    } : null
                }).ToList() ?? new List<ProjectProfessionalDTO>(),

                ProjectProposals = project.ProjectProposals?.Select(proposal => new ProposalDTO
                {
                    ProposalId = proposal.ProposalId,
                    ProposalMessage = proposal.ProposalMessage ?? string.Empty,
                    ProposalValue = proposal.ProposalValue,
                    ProposalType = proposal.ProposalType ?? string.Empty,
                    IsAccepted = proposal.IsAccepted,
                    Client = proposal.Client != null ? new ClientDTO
                    {
                        ClientId = proposal.Client.ClientId,
                        UserId = proposal.Client.UserId,
                        UserName = proposal.Client.User?.UserName ?? string.Empty,
                        Email = proposal.Client.User?.Email ?? string.Empty,
                    } : null,
                    Professional = proposal.Professional != null ? new GenericProfessionalDTO
                    {
                        Id = proposal.Professional.Id,
                        UserId = proposal.Professional.UserId,
                        UserName = proposal.Professional.User?.UserName ?? string.Empty,
                        Email = proposal.Professional.User?.Email ?? string.Empty,
                        GenericProfessionalTypeDTO = proposal.Professional.GenericProfessionalType != null ? new GenericProfessionalProfessionalTypeDTO
                        {
                            Id = proposal.Professional.GenericProfessionalType.Id,
                        } : null,
                    } : null
                }).ToList() ?? new List<ProposalDTO>()
            };
        }

        public static Projecty CriarProjetoEmDTO(this RegisterProjectModel registerProjectModel)
        {
            return new Projecty
            {
                ProjectId = registerProjectModel.ProjectId,
                ConstructionType = registerProjectModel.ConstructionType,
                Status = registerProjectModel.Status,
                Budget = registerProjectModel.Budget,
                ClientId = registerProjectModel.ClientId,
                Address = registerProjectModel.Address,
                Neighborhood = registerProjectModel.Neighborhood,
                City = registerProjectModel.City,
                State = registerProjectModel.State,
                Country = registerProjectModel.Country,
                Description = registerProjectModel.ClientDescription,
                ActStep = registerProjectModel.ActStep,
            };
        }

        public static Projecty AtualizarProjetoDTO(this ProjectsDTO updateProjectDTO)
        {
            return new Projecty
            {
                ProjectId = updateProjectDTO.ProjectId,
                ProjectName = updateProjectDTO.ProjectName,
                ConstructionType = updateProjectDTO.ConstructionType,
                Status = updateProjectDTO.Status,
                Budget = updateProjectDTO.Budget,
                StartDate = updateProjectDTO.StartDate,
                EndDate = updateProjectDTO.EndDate,
                Description = updateProjectDTO.Description,
                ClientId = updateProjectDTO.ClientId,
                Address = updateProjectDTO.Address,
                Neighborhood = updateProjectDTO.Neighborhood,
                City = updateProjectDTO.City,
                State = updateProjectDTO.State,
                PostalCode = updateProjectDTO.PostalCode,
                Country = updateProjectDTO.Country,
                TotalArea = updateProjectDTO.TotalArea,
                NumberOfRooms = updateProjectDTO.NumberOfRooms,
                NumberOfBathrooms = updateProjectDTO.NumberOfBathrooms,

                // Mapeamento de ProjectStepsDto para ProjectSteps
                ProjectSteps = MapToProjectSteps(updateProjectDTO.ProjectSteps)
            };
        }

        // Método para mapear ProjectStepsDto para ProjectSteps
        private static ProjectSteps MapToProjectSteps(ProjectStepsDto stepsDto)
        {
            if (stepsDto == null)
                return null;

            return new ProjectSteps
            {
                Id = stepsDto.Id,
                ProjectId = stepsDto.ProjectId,
                Step1HireArchitectId = stepsDto.Step1HireArchitectId,
                Step2ProjectId = stepsDto.Step2ProjectId,
                Step3ApprovalInCityHallId = stepsDto.Step3ApprovalInCityHallId,
                Step4ComplementaryProjectsId = stepsDto.Step4ComplementaryProjectsId,
                Step5BudgetSheetId = stepsDto.Step5BudgetSheetId,
                Step6ConstructionPlanningId = stepsDto.Step6ConstructionPlanningId,
                Step7PreliminaryServicesId = stepsDto.Step7PreliminaryServicesId,
                Step8ConstructionLocationId = stepsDto.Step8ConstructionLocationId,
                Step9StructuralProjectId = stepsDto.Step9StructuralProjectId,
                Step10MasonryId = stepsDto.Step10MasonryId,
                Step11RoofingId = stepsDto.Step11RoofingId,
                Step12SanitaryInstallationsId = stepsDto.Step12SanitaryInstallationsId,
                Step13ElectricalInstallationsId = stepsDto.Step13ElectricalInstallationsId,
                Step14ComplementaryInstallationsId = stepsDto.Step14ComplementaryInstallationsId,
                Step15FinishesId = stepsDto.Step15FinishesId,
                Step16DoorsAndWindowsId = stepsDto.Step16DoorsAndWindowsId,
                Step17CeilingsAndFinishesId = stepsDto.Step17CeilingsAndFinishesId,
                Step18MarbleworkId = stepsDto.Step18MarbleworkId,
                Step19LightingId = stepsDto.Step19LightingId,
                Step20FloorsId = stepsDto.Step20FloorsId,
                Step21CarpentryWashbasinsAndMetalsId = stepsDto.Step21CarpentryWashbasinsAndMetalsId,
                Step22PaintingId = stepsDto.Step22PaintingId,
                Step23LandscapingId = stepsDto.Step23LandscapingId,
                Step24CleaningOfTheSiteId = stepsDto.Step24CleaningOfTheSiteId,
                Step25DecorationId = stepsDto.Step25DecorationId
            };
        }


        // Mapeamento de ProjectProfessionalDTO para ProjectProfessional
        // Mapeamento de ProjectProfessionalDTO para ProjectProfessional
        public static ProjectProfessional ConverterDTOParaProjectProfessional(this ProjectProfessionalDTO projectProfessionalDTO)
        {
            return new ProjectProfessional
            {
                ProfessionalId = projectProfessionalDTO.ProfessionalId,
                ProjectId = projectProfessionalDTO.ProjectId,
                ContractedAs = projectProfessionalDTO.ContractedAs ?? new List<string>(),
                Salary = projectProfessionalDTO.Salary,
                Professional = projectProfessionalDTO.Professional != null ? new GenericProfessional
                {
                    Id = projectProfessionalDTO.Professional.Id,
                    UserId = projectProfessionalDTO.Professional.UserId,
                    ProfessionalTypes = projectProfessionalDTO.Professional.ProfessionalTypes,
                    GenericProfessionalType = projectProfessionalDTO.Professional.GenericProfessionalTypeDTO != null ? new GenericProfessionalProfessionalType
                    {
                        Id = projectProfessionalDTO.Professional.GenericProfessionalTypeDTO.Id,
                    } : null,
                    //Architect = projectProfessionalDTO.Professional.GeneralArchitect != null ? new Architect
                    //{
                    //    ArchId = projectProfessionalDTO.Professional.GeneralArchitect.ArchId,
                    //    RegistroConselho = projectProfessionalDTO.Professional.GeneralArchitect.RegistroConselho,
                    //    Especialidade = projectProfessionalDTO.Professional.GeneralArchitect.Especialidade
                    //} : null
                } : null
            };
        }

        // Mapeamento de ProjectProfessional para ProjectProfessionalDTO
        public static ProjectProfessionalDTO ConverterProjectProfessionalParaDTO(this ProjectProfessional projectProfessional)
        {
            return new ProjectProfessionalDTO
            {
                ProfessionalId = projectProfessional.ProfessionalId,
                ProjectId = projectProfessional.ProjectId,
                Salary = projectProfessional.Salary,
                ContractedAs = projectProfessional.ContractedAs ?? new List<string>(),
                Professional = projectProfessional.Professional != null
                    ? new GenericProfessionalDTO
                    {
                        Id = projectProfessional.Professional.Id,
                        UserId = projectProfessional.Professional.User?.Id,  // Verificação de User não nulo
                        UserName = projectProfessional.Professional.User?.UserName ?? string.Empty,  // Verificação de UserName não nulo
                        PhoneNumber = projectProfessional.Professional.User?.PhoneNumber,
                        Email = projectProfessional.Professional.User?.Email,
                        ProfessionalTypes = projectProfessional.Professional.ProfessionalTypes,
                        GenericProfessionalTypeDTO = projectProfessional.Professional.GenericProfessionalType != null
                            ? new GenericProfessionalProfessionalTypeDTO
                            {
                                Id = projectProfessional.Professional.GenericProfessionalType.Id,
                            }
                            : null
                    }
                    : null
            };
        }



    }
}
