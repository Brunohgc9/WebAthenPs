using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes;

namespace WebAthenPs.API.Mappings.MappingProfessionalsDTO
{
    public static class GenericProfessionalMapping
    {
        public static IEnumerable<GenericProfessionalDTO> ConverterProfessionalsParaDTO(
            this IEnumerable<GenericProfessional> professionals)
        {
            return (from professional in professionals
                    select new GenericProfessionalDTO
                    {
                        Id = professional.Id,
                        UserId = professional.UserId,
                        UserName = professional.User?.UserName,
                        PhoneNumber = professional.User?.PhoneNumber,
                        Email = professional.User?.Email,
                        ClientId = professional.ClientId,
                        ProfessionalTypes = professional.ProfessionalTypes,
                        ProjectProfessionals = professional.ProjectProfessionals
                            .Select(pp => new ProjectProfessionalDTO
                            {
                                ProfessionalId = pp.ProfessionalId,
                                ProjectId = pp.ProjectId,
                            }).ToList(),

                        Proposals = professional.Proposals
                            .Select(pp => new ProposalDTO
                            {
                                ProposalId = pp.ProposalId
                            }).ToList(),


                        GenericProfessionalTypeDTO = professional.GenericProfessionalType != null
                    ? new GenericProfessionalProfessionalTypeDTO
                    {
                        Id = professional.GenericProfessionalType.Id,
                        GenericId = professional.GenericProfessionalType.genericId,
                        Architect = professional.GenericProfessionalType.Architect != null
                            ? new ArchitectDTO
                            {
                                Id = professional.GenericProfessionalType.Architect.Id,
                            }
                            : null,
                        ArchitectId = professional.GenericProfessionalType.ArchitectId,
                        CivilEngineer = professional.GenericProfessionalType.CivilEngineer != null
                            ? new CivilEngineerDTO
                            {
                                Id = professional.GenericProfessionalType.CivilEngineer.Id,
                            }
                            : null,
                        CivilEngineerId = professional.GenericProfessionalType.CivilEngineerId,
                        ElectricalEngineer = professional.GenericProfessionalType.ElectricalEngineer != null
                            ? new ElectricalEngineerDTO
                            {
                                Id = professional.GenericProfessionalType.ElectricalEngineer.Id,
                            }
                            : null,
                        ElectricalEngineerId = professional.GenericProfessionalType.ElectricalEngineerId,
                        HydraulicEngineer = professional.GenericProfessionalType.HydraulicEngineer != null
                            ? new HydraulicEngineerDTO
                            {
                                Id = professional.GenericProfessionalType.HydraulicEngineer.Id,
                            }
                            : null,
                        HydraulicEngineerId = professional.GenericProfessionalType.HydraulicEngineerId,
                        Surveyor = professional.GenericProfessionalType.Surveyor != null
                            ? new SurveyorDTO
                            {
                                Id = professional.GenericProfessionalType.Surveyor.Id,
                            }
                            : null,
                        SurveyorId = professional.GenericProfessionalType.SurveyorId,
                        Foreman = professional.GenericProfessionalType.Foreman != null
                            ? new ForemanDTO
                            {
                                Id = professional.GenericProfessionalType.Foreman.Id,
                            }
                            : null,
                        ForemanId = professional.GenericProfessionalType.ForemanId,
                        Mason = professional.GenericProfessionalType.Mason != null
                            ? new MasonDTO
                            {
                                Id = professional.GenericProfessionalType.Mason.Id,
                            }
                            : null,
                        MasonId = professional.GenericProfessionalType.MasonId,
                        Plumber = professional.GenericProfessionalType.Plumber != null
                            ? new PlumberDTO
                            {
                                Id = professional.GenericProfessionalType.Plumber.Id,
                            }
                            : null,
                        PlumberId = professional.GenericProfessionalType.PlumberId,
                        Electrician = professional.GenericProfessionalType.Electrician != null
                            ? new ElectricianDTO
                            {
                                Id = professional.GenericProfessionalType.Electrician.Id,
                            }
                            : null,
                        ElectricianId = professional.GenericProfessionalType.ElectricianId,
                        Carpenter = professional.GenericProfessionalType.Carpenter != null
                            ? new CarpenterDTO
                            {
                                Id = professional.GenericProfessionalType.Carpenter.Id,
                            }
                            : null,
                        CarpenterId = professional.GenericProfessionalType.CarpenterId,
                        Roofer = professional.GenericProfessionalType.Roofer != null
                            ? new RooferDTO
                            {
                                Id = professional.GenericProfessionalType.Roofer.Id,
                            }
                            : null,
                        RooferId = professional.GenericProfessionalType.RooferId,
                        Plasterer = professional.GenericProfessionalType.Plasterer != null
                            ? new PlastererDTO
                            {
                                Id = professional.GenericProfessionalType.Plasterer.Id,
                            }
                            : null,
                        PlastererId = professional.GenericProfessionalType.PlastererId,
                        Tiler = professional.GenericProfessionalType.Tiler != null
                            ? new TilerDTO
                            {
                                Id = professional.GenericProfessionalType.Tiler.Id,
                            }
                            : null,
                        TilerId = professional.GenericProfessionalType.TilerId,
                        Painter = professional.GenericProfessionalType.Painter != null
                            ? new PainterDTO
                            {
                                Id = professional.GenericProfessionalType.Painter.Id,
                            }
                            : null,
                        PainterId = professional.GenericProfessionalType.PainterId,
                        Metalworker = professional.GenericProfessionalType.Metalworker != null
                            ? new MetalworkerDTO
                            {
                                Id = professional.GenericProfessionalType.Metalworker.Id,
                            }
                            : null,
                        MetalworkerId = professional.GenericProfessionalType.MetalworkerId,
                        Glazier = professional.GenericProfessionalType.Glazier != null
                            ? new GlazierDTO
                            {
                                Id = professional.GenericProfessionalType.Glazier.Id,
                            }
                            : null,
                        GlazierId = professional.GenericProfessionalType.GlazierId,
                        MarbleWorker = professional.GenericProfessionalType.MarbleWorker != null
                            ? new MarbleWorkerDTO
                            {
                                Id = professional.GenericProfessionalType.MarbleWorker.Id,
                            }
                            : null,
                        MarbleWorkerId = professional.GenericProfessionalType.MarbleWorkerId,
                        Landscaper = professional.GenericProfessionalType.Landscaper != null
                            ? new LandscaperDTO
                            {
                                Id = professional.GenericProfessionalType.Landscaper.Id,
                            }
                            : null,
                        LandscaperId = professional.GenericProfessionalType.LandscaperId,
                        Cabinetmaker = professional.GenericProfessionalType.Cabinetmaker != null
                            ? new CabinetmakerDTO
                            {
                                Id = professional.GenericProfessionalType.Cabinetmaker.Id,
                            }
                            : null,
                        CabinetmakerId = professional.GenericProfessionalType.CabinetmakerId,
                        InteriorDesigner = professional.GenericProfessionalType.InteriorDesigner != null
                            ? new InteriorDesignerDTO
                            {
                                Id = professional.GenericProfessionalType.InteriorDesigner.Id,
                            }
                            : null,
                        InteriorDesignerId = professional.GenericProfessionalType.InteriorDesignerId,
                        Decorator = professional.GenericProfessionalType.Decorator != null
                            ? new DecoratorDTO
                            {
                                Id = professional.GenericProfessionalType.Decorator.Id,
                            }
                            : null,
                        DecoratorId = professional.GenericProfessionalType.DecoratorId
                    }
                    : null
                    }).ToList();


        }

        public static GenericProfessionalDTO ConverterProfessionalParaDTO(this GenericProfessional professional)
        {
            return new GenericProfessionalDTO
            {
                Id = professional.Id,
                UserId = professional.UserId,
                UserName = professional.User?.UserName,
                PhoneNumber = professional.User?.PhoneNumber,
                Email = professional.User?.Email,
                ClientId = professional.ClientId,
                ProfessionalTypes = professional.ProfessionalTypes,
                ProjectProfessionals = professional.ProjectProfessionals
                    .Select(pp => new ProjectProfessionalDTO
                    {
                        ProfessionalId = pp.ProfessionalId,
                        ProjectId = pp.ProjectId,
                    }).ToList(),
                GenericProfessionalTypeDTO = professional.GenericProfessionalType != null
                    ? new GenericProfessionalProfessionalTypeDTO
                    {
                        Id = professional.GenericProfessionalType.Id,
                        GenericId = professional.GenericProfessionalType.genericId,
                        Architect = professional.GenericProfessionalType.Architect != null
                            ? new ArchitectDTO
                            {
                                Id = professional.GenericProfessionalType.Architect.Id,
                            }
                            : null,
                        ArchitectId = professional.GenericProfessionalType.ArchitectId,
                        CivilEngineer = professional.GenericProfessionalType.CivilEngineer != null
                            ? new CivilEngineerDTO
                            {
                                Id = professional.GenericProfessionalType.CivilEngineer.Id,
                            }
                            : null,
                        CivilEngineerId = professional.GenericProfessionalType.CivilEngineerId,
                        ElectricalEngineer = professional.GenericProfessionalType.ElectricalEngineer != null
                            ? new ElectricalEngineerDTO
                            {
                                Id = professional.GenericProfessionalType.ElectricalEngineer.Id,
                            }
                            : null,
                        ElectricalEngineerId = professional.GenericProfessionalType.ElectricalEngineerId,
                        HydraulicEngineer = professional.GenericProfessionalType.HydraulicEngineer != null
                            ? new HydraulicEngineerDTO
                            {
                                Id = professional.GenericProfessionalType.HydraulicEngineer.Id,
                            }
                            : null,
                        HydraulicEngineerId = professional.GenericProfessionalType.HydraulicEngineerId,
                        Surveyor = professional.GenericProfessionalType.Surveyor != null
                            ? new SurveyorDTO
                            {
                                Id = professional.GenericProfessionalType.Surveyor.Id,
                            }
                            : null,
                        SurveyorId = professional.GenericProfessionalType.SurveyorId,
                        Foreman = professional.GenericProfessionalType.Foreman != null
                            ? new ForemanDTO
                            {
                                Id = professional.GenericProfessionalType.Foreman.Id,
                            }
                            : null,
                        ForemanId = professional.GenericProfessionalType.ForemanId,
                        Mason = professional.GenericProfessionalType.Mason != null
                            ? new MasonDTO
                            {
                                Id = professional.GenericProfessionalType.Mason.Id,
                            }
                            : null,
                        MasonId = professional.GenericProfessionalType.MasonId,
                        Plumber = professional.GenericProfessionalType.Plumber != null
                            ? new PlumberDTO
                            {
                                Id = professional.GenericProfessionalType.Plumber.Id,
                            }
                            : null,
                        PlumberId = professional.GenericProfessionalType.PlumberId,
                        Electrician = professional.GenericProfessionalType.Electrician != null
                            ? new ElectricianDTO
                            {
                                Id = professional.GenericProfessionalType.Electrician.Id,
                            }
                            : null,
                        ElectricianId = professional.GenericProfessionalType.ElectricianId,
                        Carpenter = professional.GenericProfessionalType.Carpenter != null
                            ? new CarpenterDTO
                            {
                                Id = professional.GenericProfessionalType.Carpenter.Id,
                            }
                            : null,
                        CarpenterId = professional.GenericProfessionalType.CarpenterId,
                        Roofer = professional.GenericProfessionalType.Roofer != null
                            ? new RooferDTO
                            {
                                Id = professional.GenericProfessionalType.Roofer.Id,
                            }
                            : null,
                        RooferId = professional.GenericProfessionalType.RooferId,
                        Plasterer = professional.GenericProfessionalType.Plasterer != null
                            ? new PlastererDTO
                            {
                                Id = professional.GenericProfessionalType.Plasterer.Id,
                            }
                            : null,
                        PlastererId = professional.GenericProfessionalType.PlastererId,
                        Tiler = professional.GenericProfessionalType.Tiler != null
                            ? new TilerDTO
                            {
                                Id = professional.GenericProfessionalType.Tiler.Id,
                            }
                            : null,
                        TilerId = professional.GenericProfessionalType.TilerId,
                        Painter = professional.GenericProfessionalType.Painter != null
                            ? new PainterDTO
                            {
                                Id = professional.GenericProfessionalType.Painter.Id,
                            }
                            : null,
                        PainterId = professional.GenericProfessionalType.PainterId,
                        Metalworker = professional.GenericProfessionalType.Metalworker != null
                            ? new MetalworkerDTO
                            {
                                Id = professional.GenericProfessionalType.Metalworker.Id,
                            }
                            : null,
                        MetalworkerId = professional.GenericProfessionalType.MetalworkerId,
                        Glazier = professional.GenericProfessionalType.Glazier != null
                            ? new GlazierDTO
                            {
                                Id = professional.GenericProfessionalType.Glazier.Id,
                            }
                            : null,
                        GlazierId = professional.GenericProfessionalType.GlazierId,
                        MarbleWorker = professional.GenericProfessionalType.MarbleWorker != null
                            ? new MarbleWorkerDTO
                            {
                                Id = professional.GenericProfessionalType.MarbleWorker.Id,
                            }
                            : null,
                        MarbleWorkerId = professional.GenericProfessionalType.MarbleWorkerId,
                        Landscaper = professional.GenericProfessionalType.Landscaper != null
                            ? new LandscaperDTO
                            {
                                Id = professional.GenericProfessionalType.Landscaper.Id,
                            }
                            : null,
                        LandscaperId = professional.GenericProfessionalType.LandscaperId,
                        Cabinetmaker = professional.GenericProfessionalType.Cabinetmaker != null
                            ? new CabinetmakerDTO
                            {
                                Id = professional.GenericProfessionalType.Cabinetmaker.Id,
                            }
                            : null,
                        CabinetmakerId = professional.GenericProfessionalType.CabinetmakerId,
                        InteriorDesigner = professional.GenericProfessionalType.InteriorDesigner != null
                            ? new InteriorDesignerDTO
                            {
                                Id = professional.GenericProfessionalType.InteriorDesigner.Id,
                            }
                            : null,
                        InteriorDesignerId = professional.GenericProfessionalType.InteriorDesignerId,
                        Decorator = professional.GenericProfessionalType.Decorator != null
                            ? new DecoratorDTO
                            {
                                Id = professional.GenericProfessionalType.Decorator.Id,
                            }
                            : null,
                        DecoratorId = professional.GenericProfessionalType.DecoratorId
                    }
                    : null,
                Proposals = professional.Proposals
                .Select(pp => new ProposalDTO
                {
                    ProposalId = pp.ProposalId
                }).ToList(),
            };
        }

        public static GenericProfessionalProfessionalType MapToProfessionalType(
    GenericProfessionalProfessionalTypeDTO dto)
        {
            return new GenericProfessionalProfessionalType
            {
                Id = dto.Id,
                genericId = dto.GenericId,
                Architect = dto.Architect != null ? new Architect { Id = dto.Architect.Id } : null,
                ArchitectId = dto.ArchitectId,
                CivilEngineer = dto.CivilEngineer != null ? new CivilEngineer { Id = dto.CivilEngineer.Id } : null,
                CivilEngineerId = dto.CivilEngineerId,
                ElectricalEngineer = dto.ElectricalEngineer != null ? new ElectricalEngineer { Id = dto.ElectricalEngineer.Id } : null,
                ElectricalEngineerId = dto.ElectricalEngineerId,
                HydraulicEngineer = dto.HydraulicEngineer != null ? new HydraulicEngineer { Id = dto.HydraulicEngineer.Id } : null,
                HydraulicEngineerId = dto.HydraulicEngineerId,
                Surveyor = dto.Surveyor != null ? new Surveyor { Id = dto.Surveyor.Id } : null,
                SurveyorId = dto.SurveyorId,
                Foreman = dto.Foreman != null ? new Foreman { Id = dto.Foreman.Id } : null,
                ForemanId = dto.ForemanId,
                Mason = dto.Mason != null ? new Mason { Id = dto.Mason.Id } : null,
                MasonId = dto.MasonId,
                Plumber = dto.Plumber != null ? new Plumber { Id = dto.Plumber.Id } : null,
                PlumberId = dto.PlumberId,
                Electrician = dto.Electrician != null ? new Electrician { Id = dto.Electrician.Id } : null,
                ElectricianId = dto.ElectricianId,
                Carpenter = dto.Carpenter != null ? new Carpenter { Id = dto.Carpenter.Id } : null,
                CarpenterId = dto.CarpenterId,
                Roofer = dto.Roofer != null ? new Roofer { Id = dto.Roofer.Id } : null,
                RooferId = dto.RooferId,
                Plasterer = dto.Plasterer != null ? new Plasterer { Id = dto.Plasterer.Id } : null,
                PlastererId = dto.PlastererId,
                Tiler = dto.Tiler != null ? new Tiler { Id = dto.Tiler.Id } : null,
                TilerId = dto.TilerId,
                Painter = dto.Painter != null ? new Painter { Id = dto.Painter.Id } : null,
                PainterId = dto.PainterId,
                Metalworker = dto.Metalworker != null ? new Metalworker { Id = dto.Metalworker.Id } : null,
                MetalworkerId = dto.MetalworkerId,
                Glazier = dto.Glazier != null ? new Glazier { Id = dto.Glazier.Id } : null,
                GlazierId = dto.GlazierId,
                MarbleWorker = dto.MarbleWorker != null ? new MarbleWorker { Id = dto.MarbleWorker.Id } : null,
                MarbleWorkerId = dto.MarbleWorkerId,
                Landscaper = dto.Landscaper != null ? new Landscaper { Id = dto.Landscaper.Id } : null,
                LandscaperId = dto.LandscaperId,
                Cabinetmaker = dto.Cabinetmaker != null ? new Cabinetmaker { Id = dto.Cabinetmaker.Id } : null,
                CabinetmakerId = dto.CabinetmakerId,
                InteriorDesigner = dto.InteriorDesigner != null ? new InteriorDesigner { Id = dto.InteriorDesigner.Id } : null,
                InteriorDesignerId = dto.InteriorDesignerId,
                Decorator = dto.Decorator != null ? new Decorator { Id = dto.Decorator.Id } : null,
                DecoratorId = dto.DecoratorId
            };
        }

        public static IEnumerable<GenericProfessional> CriarProfessionalsEmDTO(
            this IEnumerable<RegisterProfessionalModel> dtos)
        {
            return (from dto in dtos
                    select new GenericProfessional
                    {
                        UserId = dto.UserId,
                        ProfessionalTypes = dto.ProfessionalTypes,
                        GenericProfessionalType = dto.GenericProfessionalType != null
                            ? MapToProfessionalType(dto.GenericProfessionalType)
                            : null
                    }).ToList();
        }

        public static GenericProfessional CriarProfessionalEmDTO(this RegisterProfessionalModel dto)
        {
            return new GenericProfessional
            {
                UserId = dto.UserId,
                ProfessionalTypes = dto.ProfessionalTypes,
                GenericProfessionalType = dto.GenericProfessionalType != null
                    ? new GenericProfessionalProfessionalType
                    {
                        Id = dto.GenericProfessionalType.Id,
                        genericId = dto.GenericProfessionalType.GenericId,
                        Architect = dto.GenericProfessionalType.Architect != null
                            ? new Architect
                            {
                                Id = dto.GenericProfessionalType.Architect.Id,
                            }
                            : null,
                        ArchitectId = dto.GenericProfessionalType.ArchitectId,
                        CivilEngineer = dto.GenericProfessionalType.CivilEngineer != null
                            ? new CivilEngineer
                            {
                                Id = dto.GenericProfessionalType.CivilEngineer.Id,
                            }
                            : null,
                        CivilEngineerId = dto.GenericProfessionalType.CivilEngineerId,
                        ElectricalEngineer = dto.GenericProfessionalType.ElectricalEngineer != null
                            ? new ElectricalEngineer
                            {
                                Id = dto.GenericProfessionalType.ElectricalEngineer.Id,
                            }
                            : null,
                        ElectricalEngineerId = dto.GenericProfessionalType.ElectricalEngineerId,
                        HydraulicEngineer = dto.GenericProfessionalType.HydraulicEngineer != null
                            ? new HydraulicEngineer
                            {
                                Id = dto.GenericProfessionalType.HydraulicEngineer.Id,
                            }
                            : null,
                        HydraulicEngineerId = dto.GenericProfessionalType.HydraulicEngineerId,
                        Surveyor = dto.GenericProfessionalType.Surveyor != null
                            ? new Surveyor
                            {
                                Id = dto.GenericProfessionalType.Surveyor.Id,
                            }
                            : null,
                        SurveyorId = dto.GenericProfessionalType.SurveyorId,
                        Foreman = dto.GenericProfessionalType.Foreman != null
                            ? new Foreman
                            {
                                Id = dto.GenericProfessionalType.Foreman.Id,
                            }
                            : null,
                        ForemanId = dto.GenericProfessionalType.ForemanId,
                        Mason = dto.GenericProfessionalType.Mason != null
                            ? new Mason
                            {
                                Id = dto.GenericProfessionalType.Mason.Id,
                            }
                            : null,
                        MasonId = dto.GenericProfessionalType.MasonId,
                        Plumber = dto.GenericProfessionalType.Plumber != null
                            ? new Plumber
                            {
                                Id = dto.GenericProfessionalType.Plumber.Id,
                            }
                            : null,
                        PlumberId = dto.GenericProfessionalType.PlumberId,
                        Electrician = dto.GenericProfessionalType.Electrician != null
                            ? new Electrician
                            {
                                Id = dto.GenericProfessionalType.Electrician.Id,
                            }
                            : null,
                        ElectricianId = dto.GenericProfessionalType.ElectricianId,
                        Carpenter = dto.GenericProfessionalType.Carpenter != null
                            ? new Carpenter
                            {
                                Id = dto.GenericProfessionalType.Carpenter.Id,
                            }
                            : null,
                        CarpenterId = dto.GenericProfessionalType.CarpenterId,
                        Roofer = dto.GenericProfessionalType.Roofer != null
                            ? new Roofer
                            {
                                Id = dto.GenericProfessionalType.Roofer.Id,
                            }
                            : null,
                        RooferId = dto.GenericProfessionalType.RooferId,
                        Plasterer = dto.GenericProfessionalType.Plasterer != null
                            ? new Plasterer
                            {
                                Id = dto.GenericProfessionalType.Plasterer.Id,
                            }
                            : null,
                        PlastererId = dto.GenericProfessionalType.PlastererId,
                        Tiler = dto.GenericProfessionalType.Tiler != null
                            ? new Tiler
                            {
                                Id = dto.GenericProfessionalType.Tiler.Id,
                            }
                            : null,
                        TilerId = dto.GenericProfessionalType.TilerId,
                        Painter = dto.GenericProfessionalType.Painter != null
                            ? new Painter
                            {
                                Id = dto.GenericProfessionalType.Painter.Id,
                            }
                            : null,
                        PainterId = dto.GenericProfessionalType.PainterId,
                        Metalworker = dto.GenericProfessionalType.Metalworker != null
                            ? new Metalworker
                            {
                                Id = dto.GenericProfessionalType.Metalworker.Id,
                            }
                            : null,
                        MetalworkerId = dto.GenericProfessionalType.MetalworkerId,
                        Glazier = dto.GenericProfessionalType.Glazier != null
                            ? new Glazier
                            {
                                Id = dto.GenericProfessionalType.Glazier.Id,
                            }
                            : null,
                        GlazierId = dto.GenericProfessionalType.GlazierId,
                        MarbleWorker = dto.GenericProfessionalType.MarbleWorker != null
                            ? new MarbleWorker
                            {
                                Id = dto.GenericProfessionalType.MarbleWorker.Id,
                            }
                            : null,
                        MarbleWorkerId = dto.GenericProfessionalType.MarbleWorkerId,
                        Landscaper = dto.GenericProfessionalType.Landscaper != null
                            ? new Landscaper
                            {
                                Id = dto.GenericProfessionalType.Landscaper.Id,
                            }
                            : null,
                        LandscaperId = dto.GenericProfessionalType.LandscaperId,
                        Cabinetmaker = dto.GenericProfessionalType.Cabinetmaker != null
                            ? new Cabinetmaker
                            {
                                Id = dto.GenericProfessionalType.Cabinetmaker.Id,
                            }
                            : null,
                        CabinetmakerId = dto.GenericProfessionalType.CabinetmakerId,
                        InteriorDesigner = dto.GenericProfessionalType.InteriorDesigner != null
                            ? new InteriorDesigner
                            {
                                Id = dto.GenericProfessionalType.InteriorDesigner.Id,
                            }
                            : null,
                        InteriorDesignerId = dto.GenericProfessionalType.InteriorDesignerId,
                        Decorator = dto.GenericProfessionalType.Decorator != null
                            ? new Decorator
                            {
                                Id = dto.GenericProfessionalType.Decorator.Id,
                            }
                            : null,
                        DecoratorId = dto.GenericProfessionalType.DecoratorId
                    }
                    : null
            };
        }

    }

}
