using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation
{
    public class GenericProfessionalProfessionalType
    {
        public Guid Id { get; set; }


        [ForeignKey("genericId")]
        public GenericProfessional Professional { get; set; }

        public int genericId { get; set; }


        [ForeignKey("ArchitectId")]
        public Architect Architect { get; set; }
        public int? ArchitectId { get; set; }


        [ForeignKey("CivilEngineerId")]
        public CivilEngineer CivilEngineer { get; set; }
        public int? CivilEngineerId { get; set; }

        [ForeignKey("ElectricalEngineerId")]
        public ElectricalEngineer ElectricalEngineer { get; set; }
        public int? ElectricalEngineerId { get; set; }

        [ForeignKey("HydraulicEngineerId")]
        public HydraulicEngineer HydraulicEngineer { get; set; }
        public int? HydraulicEngineerId { get; set; }

        [ForeignKey("SurveyorId")]
        public Surveyor Surveyor { get; set; }
        public int? SurveyorId { get; set; }

        [ForeignKey("ForemanId")]
        public Foreman Foreman { get; set; }
        public int? ForemanId { get; set; }

        [ForeignKey("MasonId")]
        public Mason Mason { get; set; }
        public int? MasonId { get; set; }

        [ForeignKey("PlumberId")]
        public Plumber Plumber { get; set; }
        public int? PlumberId { get; set; }

        [ForeignKey("ElectricianId")]
        public Electrician Electrician { get; set; }
        public int? ElectricianId { get; set; }

        [ForeignKey("CarpenterId")]
        public Carpenter Carpenter { get; set; }
        public int? CarpenterId { get; set; }

        [ForeignKey("RooferId")]
        public Roofer Roofer { get; set; }
        public int? RooferId { get; set; }

        [ForeignKey("PlastererId")]
        public Plasterer Plasterer { get; set; }
        public int? PlastererId { get; set; }

        [ForeignKey("TilerId")]
        public Tiler Tiler { get; set; }
        public int? TilerId { get; set; }

        [ForeignKey("PainterId")]
        public Painter Painter { get; set; }
        public int? PainterId { get; set; }

        [ForeignKey("MetalworkerId")]
        public Metalworker Metalworker { get; set; }
        public int? MetalworkerId { get; set; }

        [ForeignKey("GlazierId")]
        public Glazier Glazier { get; set; }
        public int? GlazierId { get; set; }

        [ForeignKey("MarbleWorkerId")]
        public MarbleWorker MarbleWorker { get; set; }
        public int? MarbleWorkerId { get; set; }

        [ForeignKey("LandscaperId")]
        public Landscaper Landscaper { get; set; }
        public int? LandscaperId { get; set; }

        [ForeignKey("CabinetmakerId")]
        public Cabinetmaker Cabinetmaker { get; set; }
        public int? CabinetmakerId { get; set; }

        [ForeignKey("InteriorDesignerId")]
        public InteriorDesigner InteriorDesigner { get; set; }
        public int? InteriorDesignerId { get; set; }

        [ForeignKey("DecoratorId")]
        public Decorator Decorator { get; set; }
        public int? DecoratorId { get; set; }




    }
}
