using AutoMapper;
using WebAthenPs.API.Entities;
using WebAthenPs.Models.DTOs;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
{
    public class DomainToDTOProfile : Profile
    {
        public DomainToDTOProfile()
        {
            // Mapeamento entre GenericProfessional e GProfessionalDTO
            // Mapeamento entre GenericProfessional e GProfessionalDTO
            CreateMap<GenericProfessional, GProfessionalDTO>()
                .ForMember(dest => dest.GProfessionalId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User != null ? src.User.UserName : null))
                .ForMember(dest => dest.ProfessionalType, opt => opt.MapFrom(src => src.ProfessionalType))
                .ForMember(dest => dest.Projects, opt => opt.MapFrom(src => src.Projects != null ? src.Projects.Select(pr => new ProjectsDTO
                {
                    ProjectId = pr.ProjectId,
                    ProjectName = pr.ProjectName
                }).ToList() : new List<ProjectsDTO>()));

            // Mapeamento reverso entre GProfessionalDTO e GenericProfessional
            CreateMap<GProfessionalDTO, GenericProfessional>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.GProfessionalId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.ProfessionalType, opt => opt.MapFrom(src => src.ProfessionalType));

        }
    }
}
