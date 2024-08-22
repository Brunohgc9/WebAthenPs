﻿using WebAthenPs.API.Entities;
using WebAthenPs.Models.DTOs;
using System.Collections.Generic;
using System.Linq;

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
                ClientName = item.Client?.User?.UserName,
                Address = item.Address,
                Neighborhood = item.Neighborhood,
                City = item.City,
                State = item.State,
                PostalCode = item.PostalCode,
                Country = item.Country,
                TotalArea = item.TotalArea,
                NumberOfRooms = item.NumberOfRooms,
                Step = item.ActStep,
                NumberOfBathrooms = item.NumberOfBathrooms,
                Professionals = item.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserName = p.User?.UserName,
                    ProfessionalType = p.ProfessionalType
                }).ToList() ?? new List<GenericProfessionalDTO>()
            }) ?? Enumerable.Empty<ProjectsDTO>();
        }

        public static ProjectsDTO ConverterProjetoParaDTO(this Projecty project)
        {
            return new ProjectsDTO
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName,
                ConstructionType = project.ConstructionType,
                Status = project.Status,
                Budget = project.Budget,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Description = project.Description,
                ClientId = project.Client?.ClientId ?? default,
                ClientName = project.Client?.User?.UserName,
                Address = project.Address,
                Neighborhood = project.Neighborhood,
                City = project.City,
                State = project.State,
                PostalCode = project.PostalCode,
                Country = project.Country,
                Step = project.ActStep,
                TotalArea = project.TotalArea,
                NumberOfRooms = project.NumberOfRooms,
                NumberOfBathrooms = project.NumberOfBathrooms,
                Professionals = project.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserName = p.User?.UserName,
                    ProfessionalType = p.ProfessionalType
                }).ToList() ?? new List<GenericProfessionalDTO>()
            };
        }
    }
}