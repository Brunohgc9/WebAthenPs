using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation
{
    public class GenericProfessionalProfessionalType
    {
        public Guid Id { get; set; }

        public int? genericId { get; set; }


        [ForeignKey("genericId")]
        public GenericProfessional? Professional { get; set; }


        [ForeignKey("ArchitectId")]
        public Architect? Architect { get; set; }
        public Guid? ArchitectId { get; set; }


        [ForeignKey("CivilEngineerId")]
        public CivilEngineer? CivilEngineer { get; set; }
        public Guid? CivilEngineerId { get; set; }

        [ForeignKey("ElectricalEngineerId")]
        public ElectricalEngineer? ElectricalEngineer { get; set; }
        public Guid? ElectricalEngineerId { get; set; }

        [ForeignKey("HydraulicEngineerId")]
        public HydraulicEngineer? HydraulicEngineer { get; set; }
        public Guid? HydraulicEngineerId { get; set; }

        [ForeignKey("SurveyorId")]
        public Surveyor? Surveyor { get; set; }
        public Guid? SurveyorId { get; set; }

        [ForeignKey("ForemanId")]
        public Foreman? Foreman { get; set; }
        public Guid? ForemanId { get; set; }

        [ForeignKey("MasonId")]
        public Mason? Mason { get; set; }
        public Guid? MasonId { get; set; }

        [ForeignKey("PlumberId")]
        public Plumber? Plumber { get; set; }
        public Guid? PlumberId { get; set; }

        [ForeignKey("ElectricianId")]
        public Electrician? Electrician { get; set; }
        public Guid? ElectricianId { get; set; }

        [ForeignKey("CarpenterId")]
        public Carpenter? Carpenter { get; set; }
        public Guid? CarpenterId { get; set; }

        [ForeignKey("RooferId")]
        public Roofer? Roofer { get; set; }
        public Guid? RooferId { get; set; }

        [ForeignKey("PlastererId")]
        public Plasterer? Plasterer { get; set; }
        public Guid? PlastererId { get; set; }

        [ForeignKey("TilerId")]
        public Tiler? Tiler { get; set; }
        public Guid? TilerId { get; set; }

        [ForeignKey("PainterId")]
        public Painter? Painter { get; set; }
        public Guid? PainterId { get; set; }

        [ForeignKey("MetalworkerId")]
        public Metalworker? Metalworker { get; set; }
        public Guid? MetalworkerId { get; set; }

        [ForeignKey("GlazierId")]
        public Glazier? Glazier { get; set; }
        public Guid? GlazierId { get; set; }

        [ForeignKey("MarbleWorkerId")]
        public MarbleWorker? MarbleWorker { get; set; }
        public Guid? MarbleWorkerId { get; set; }

        [ForeignKey("LandscaperId")]
        public Landscaper? Landscaper { get; set; }
        public Guid? LandscaperId { get; set; }

        [ForeignKey("CabinetmakerId")]
        public Cabinetmaker? Cabinetmaker { get; set; }
        public Guid? CabinetmakerId { get; set; }

        [ForeignKey("InteriorDesignerId")]
        public InteriorDesigner? InteriorDesigner { get; set; }
        public Guid? InteriorDesignerId { get; set; }

        [ForeignKey("DecoratorId")]
        public Decorator? Decorator { get; set; }
        public Guid? DecoratorId { get; set; }




    }
}
