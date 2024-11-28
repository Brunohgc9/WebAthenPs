using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Project.Steps
{
    public class AllProjectSteps
    {
        public Guid Id { get; set; }

        [ForeignKey("ProjectStepsId")]
        public ProjectSteps Project { get; set; }
        public Guid ProjectStepsId { get; set; }

        public string? Description { get; set; }

    }
}
