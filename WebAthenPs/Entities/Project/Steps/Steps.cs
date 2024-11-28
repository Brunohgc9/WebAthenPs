using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;

namespace WebAthenPs.API.Entities.Project.Steps
{
    public class Step1HireArchitect : AllProjectSteps
    {
        [ForeignKey("ArchitectId")]
        public Architect Architect { get; set; }
        public Guid ArchitectId { get; set; }
    }
    public class Step2Project : AllProjectSteps
    {
        // 2nd Step: 3,52m - PROJECT
    }
    public class Step3ApprovalInCityHall : AllProjectSteps
    {
        // 3rd Step: 7,47m - APPROVAL IN CITY HALL
    }
    public class Step4ComplementaryProjects : AllProjectSteps
    {
        // 4th Step: 11,08m - COMPLEMENTARY PROJECTS
    }
    public class Step5BudgetSheet : AllProjectSteps
    {
        // 5th Step: 12,32m - BUDGET SHEET
    }
    public class Step6ConstructionPlanning : AllProjectSteps
    {
        // 6th Step: 13,48m - CONSTRUCTION PLANNING
    }
    public class Step7PreliminaryServices : AllProjectSteps
    {
        // 7th Step: 15,28m - PRELIMINARY SERVICES
    }
    public class Step8ConstructionLocation : AllProjectSteps
    {
        // 8th Step: 17,19m - CONSTRUCTION LOCATION
    }
    public class Step9StructuralProject : AllProjectSteps
    {
        // 9th Step: 18,14m - STRUCTURAL PROJECT
    }
    public class Step10Masonry : AllProjectSteps
    {
        // 10th Step: 18,39m - MASONRY
    }
    public class Step11Roofing : AllProjectSteps
    {
        // 11th Step: 19,31m - ROOFING
    }
    public class Step12SanitaryInstallations : AllProjectSteps
    {
        // 12th Step: 20,58m - SANITARY INSTALLATIONS
    }
    public class Step13ElectricalInstallations : AllProjectSteps
    {
        // 13th Step: 21,31m - ELECTRICAL INSTALLATIONS
    }
    public class Step14ComplementaryInstallations : AllProjectSteps
    {
        // 14th Step: 22,11m - COMPLEMENTARY INSTALLATIONS
    }
    public class Step15Finishes : AllProjectSteps
    {
        // 15th Step: 22,27m - FINISHES
    }
    public class Step16DoorsAndWindows : AllProjectSteps
    {
        // 16th Step: 23,00m - DOORS AND WINDOWS
    }
    public class Step17CeilingsAndFinishes : AllProjectSteps
    {
        // 17th Step: 23,16m - CEILINGS AND FINISHES
    }
    public class Step18Marblework : AllProjectSteps
    {
        // 18th Step: 23,48m - MARBLEWORK
    }
    public class Step19Lighting : AllProjectSteps
    {
        // 19th Step: 25,13m - LIGHTING
    }
    public class Step20Floors : AllProjectSteps
    {
        // 20th Step: 25,40m - FLOORS
    }
    public class Step21CarpentryWashbasinsAndMetals : AllProjectSteps
    {
        // 21st Step: 26,18m - CARPENTRY, WASHBASINS AND METALS
    }
    public class Step22Painting : AllProjectSteps
    {
        // 22nd Step: 26,27m - PAINTING
    }
    public class Step23Landscaping : AllProjectSteps
    {
        // 23rd Step: 28,03m - LANDSCAPING
    }
    public class Step24CleaningOfTheSite : AllProjectSteps
    {
        // 24th Step: 28,19m - CLEANING OF THE SITE
    }
    public class Step25Decoration : AllProjectSteps
    {
        // 25th Step: 28,49m - DECORATION
    }

}
