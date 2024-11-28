using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes;

namespace WebAthenPs.Models.DTOs.Project.Steps
{
    public class AllProjectStepsDto
    {
        public Guid Id { get; set; }
        public Guid ProjectStepsId { get; set; }
        public string? Description { get; set; }
        public bool? IsFinished {get; set;}

    }

    // DTO para ProjectSteps
    public class ProjectStepsDto
    {
        public Guid Id { get; set; }
        public int ProjectId { get; set; }

        // Propriedades opcionais para cada etapa
        public Guid? Step1HireArchitectId { get; set; }
        public Guid? Step2ProjectId { get; set; }
        public Guid? Step3ApprovalInCityHallId { get; set; }
        public Guid? Step4ComplementaryProjectsId { get; set; }
        public Guid? Step5BudgetSheetId { get; set; }
        public Guid? Step6ConstructionPlanningId { get; set; }
        public Guid? Step7PreliminaryServicesId { get; set; }
        public Guid? Step8ConstructionLocationId { get; set; }
        public Guid? Step9StructuralProjectId { get; set; }
        public Guid? Step10MasonryId { get; set; }
        public Guid? Step11RoofingId { get; set; }
        public Guid? Step12SanitaryInstallationsId { get; set; }
        public Guid? Step13ElectricalInstallationsId { get; set; }
        public Guid? Step14ComplementaryInstallationsId { get; set; }
        public Guid? Step15FinishesId { get; set; }
        public Guid? Step16DoorsAndWindowsId { get; set; }
        public Guid? Step17CeilingsAndFinishesId { get; set; }
        public Guid? Step18MarbleworkId { get; set; }
        public Guid? Step19LightingId { get; set; }
        public Guid? Step20FloorsId { get; set; }
        public Guid? Step21CarpentryWashbasinsAndMetalsId { get; set; }
        public Guid? Step22PaintingId { get; set; }
        public Guid? Step23LandscapingId { get; set; }
        public Guid? Step24CleaningOfTheSiteId { get; set; }
        public Guid? Step25DecorationId { get; set; }
    }

    // DTOs específicos para cada etapa
    public class Step1HireArchitectDto : AllProjectStepsDto 
    {
        public ArchitectDTO? Architect { get; set; }
        public Guid ArchitectId { get; set; }
    }
    public class Step2ProjectDto : AllProjectStepsDto { }
    public class Step3ApprovalInCityHallDto : AllProjectStepsDto { }
    public class Step4ComplementaryProjectsDto : AllProjectStepsDto { }
    public class Step5BudgetSheetDto : AllProjectStepsDto { }
    public class Step6ConstructionPlanningDto : AllProjectStepsDto { }
    public class Step7PreliminaryServicesDto : AllProjectStepsDto { }
    public class Step8ConstructionLocationDto : AllProjectStepsDto { }
    public class Step9StructuralProjectDto : AllProjectStepsDto { }
    public class Step10MasonryDto : AllProjectStepsDto { }
    public class Step11RoofingDto : AllProjectStepsDto { }
    public class Step12SanitaryInstallationsDto : AllProjectStepsDto { }
    public class Step13ElectricalInstallationsDto : AllProjectStepsDto { }
    public class Step14ComplementaryInstallationsDto : AllProjectStepsDto { }
    public class Step15FinishesDto : AllProjectStepsDto { }
    public class Step16DoorsAndWindowsDto : AllProjectStepsDto { }
    public class Step17CeilingsAndFinishesDto : AllProjectStepsDto { }
    public class Step18MarbleworkDto : AllProjectStepsDto { }
    public class Step19LightingDto : AllProjectStepsDto { }
    public class Step20FloorsDto : AllProjectStepsDto { }
    public class Step21CarpentryWashbasinsAndMetalsDto : AllProjectStepsDto { }
    public class Step22PaintingDto : AllProjectStepsDto { }
    public class Step23LandscapingDto : AllProjectStepsDto { }
    public class Step24CleaningOfTheSiteDto : AllProjectStepsDto { }
    public class Step25DecorationDto : AllProjectStepsDto { }
}
