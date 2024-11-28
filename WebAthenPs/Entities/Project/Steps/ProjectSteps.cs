using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Project.Steps
{
    public class ProjectSteps
    {
        public Guid Id { get; set; }

        [ForeignKey("ProjectId")]
        public Projecty Projecty { get; set; }
        public int ProjectId { get; set; }

        // Referências para todas as etapas do projeto
        [ForeignKey("Step1HireArchitectId")]
        public Step1HireArchitect? Step1HireArchitect { get; set; }
        public Guid? Step1HireArchitectId { get; set; }

        [ForeignKey("Step2ProjectId")]
        public Step2Project? Step2Project { get; set; }
        public Guid? Step2ProjectId { get; set; }

        [ForeignKey("Step3ApprovalInCityHallId")]
        public Step3ApprovalInCityHall? Step3ApprovalInCityHall { get; set; }
        public Guid? Step3ApprovalInCityHallId { get; set; }

        [ForeignKey("Step4ComplementaryProjectsId")]
        public Step4ComplementaryProjects? Step4ComplementaryProjects { get; set; }
        public Guid? Step4ComplementaryProjectsId { get; set; }

        [ForeignKey("Step5BudgetSheetId")]
        public Step5BudgetSheet? Step5BudgetSheet { get; set; }
        public Guid? Step5BudgetSheetId { get; set; }

        [ForeignKey("Step6ConstructionPlanningId")]
        public Step6ConstructionPlanning? Step6ConstructionPlanning { get; set; }
        public Guid? Step6ConstructionPlanningId { get; set; }

        [ForeignKey("Step7PreliminaryServicesId")]
        public Step7PreliminaryServices? Step7PreliminaryServices { get; set; }
        public Guid? Step7PreliminaryServicesId { get; set; }

        [ForeignKey("Step8ConstructionLocationId")]
        public Step8ConstructionLocation? Step8ConstructionLocation { get; set; }
        public Guid? Step8ConstructionLocationId { get; set; }

        [ForeignKey("Step9StructuralProjectId")]
        public Step9StructuralProject? Step9StructuralProject { get; set; }
        public Guid? Step9StructuralProjectId { get; set; }

        [ForeignKey("Step10MasonryId")]
        public Step10Masonry? Step10Masonry { get; set; }
        public Guid? Step10MasonryId { get; set; }

        [ForeignKey("Step11RoofingId")]
        public Step11Roofing? Step11Roofing { get; set; }
        public Guid? Step11RoofingId { get; set; }

        [ForeignKey("Step12SanitaryInstallationsId")]
        public Step12SanitaryInstallations? Step12SanitaryInstallations { get; set; }
        public Guid? Step12SanitaryInstallationsId { get; set; }

        [ForeignKey("Step13ElectricalInstallationsId")]
        public Step13ElectricalInstallations? Step13ElectricalInstallations { get; set; }
        public Guid? Step13ElectricalInstallationsId { get; set; }

        [ForeignKey("Step14ComplementaryInstallationsId")]
        public Step14ComplementaryInstallations? Step14ComplementaryInstallations { get; set; }
        public Guid? Step14ComplementaryInstallationsId { get; set; }

        [ForeignKey("Step15FinishesId")]
        public Step15Finishes? Step15Finishes { get; set; }
        public Guid? Step15FinishesId { get; set; }

        [ForeignKey("Step16DoorsAndWindowsId")]
        public Step16DoorsAndWindows? Step16DoorsAndWindows { get; set; }
        public Guid? Step16DoorsAndWindowsId { get; set; }

        [ForeignKey("Step17CeilingsAndFinishesId")]
        public Step17CeilingsAndFinishes? Step17CeilingsAndFinishes { get; set; }
        public Guid? Step17CeilingsAndFinishesId { get; set; }

        [ForeignKey("Step18MarbleworkId")]
        public Step18Marblework? Step18Marblework { get; set; }
        public Guid? Step18MarbleworkId { get; set; }

        [ForeignKey("Step19LightingId")]
        public Step19Lighting? Step19Lighting { get; set; }
        public Guid? Step19LightingId { get; set; }

        [ForeignKey("Step20FloorsId")]
        public Step20Floors? Step20Floors { get; set; }
        public Guid? Step20FloorsId { get; set; }

        [ForeignKey("Step21CarpentryWashbasinsAndMetalsId")]
        public Step21CarpentryWashbasinsAndMetals? Step21CarpentryWashbasinsAndMetals { get; set; }
        public Guid? Step21CarpentryWashbasinsAndMetalsId { get; set; }

        [ForeignKey("Step22PaintingId")]
        public Step22Painting? Step22Painting { get; set; }
        public Guid? Step22PaintingId { get; set; }

        [ForeignKey("Step23LandscapingId")]
        public Step23Landscaping? Step23Landscaping { get; set; }
        public Guid? Step23LandscapingId { get; set; }

        [ForeignKey("Step24CleaningOfTheSiteId")]
        public Step24CleaningOfTheSite? Step24CleaningOfTheSite { get; set; }
        public Guid? Step24CleaningOfTheSiteId { get; set; }

        [ForeignKey("Step25DecorationId")]
        public Step25Decoration? Step25Decoration { get; set; }
        public Guid? Step25DecorationId { get; set; }
    }
}
