using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional.ProfessionalTypes
{
    public class GenericProfessionalProfessionalTypeDTO
    {
        public Guid Id { get; set; }
        public GenericProfessionalDTO? Professional { get; set; }
        public int? GenericId { get; set; }

        public ArchitectDTO? Architect { get; set; }
        public Guid? ArchitectId { get; set; }

        public CivilEngineerDTO? CivilEngineer { get; set; }
        public Guid? CivilEngineerId { get; set; }

        public ElectricalEngineerDTO? ElectricalEngineer { get; set; }
        public Guid? ElectricalEngineerId { get; set; }

        public HydraulicEngineerDTO? HydraulicEngineer { get; set; }
        public Guid? HydraulicEngineerId { get; set; }

        public SurveyorDTO? Surveyor { get; set; }
        public Guid? SurveyorId { get; set; }

        public ForemanDTO? Foreman { get; set; }
        public Guid? ForemanId { get; set; }

        public MasonDTO? Mason { get; set; }
        public Guid? MasonId { get; set; }

        public PlumberDTO? Plumber { get; set; }
        public Guid? PlumberId { get; set; }

        public ElectricianDTO? Electrician { get; set; }
        public Guid? ElectricianId { get; set; }

        public CarpenterDTO? Carpenter { get; set; }
        public Guid? CarpenterId { get; set; }

        public RooferDTO? Roofer { get; set; }
        public Guid? RooferId { get; set; }

        public PlastererDTO? Plasterer { get; set; }
        public Guid? PlastererId { get; set; }

        public TilerDTO? Tiler { get; set; }
        public Guid? TilerId { get; set; }

        public PainterDTO? Painter { get; set; }
        public Guid? PainterId { get; set; }

        public MetalworkerDTO? Metalworker { get; set; }
        public Guid? MetalworkerId { get; set; }

        public GlazierDTO? Glazier { get; set; }
        public Guid? GlazierId { get; set; }

        public MarbleWorkerDTO? MarbleWorker { get; set; }
        public Guid? MarbleWorkerId { get; set; }

        public LandscaperDTO? Landscaper { get; set; }
        public Guid? LandscaperId { get; set; }

        public CabinetmakerDTO? Cabinetmaker { get; set; }
        public Guid? CabinetmakerId { get; set; }

        public InteriorDesignerDTO? InteriorDesigner { get; set; }
        public Guid? InteriorDesignerId { get; set; }

        public DecoratorDTO? Decorator { get; set; }
        public Guid? DecoratorId { get; set; }
    }
}
