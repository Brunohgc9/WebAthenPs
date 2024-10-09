using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Project;

public class ProjectProfessional
{
    [Key]
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public Projecty Project { get; set; }

    public int ProfessionalId { get; set; }
    public GenericProfessional? Professional { get; set; }

    public List<string> ContractedAs { get; set; } = new List<string>();
}
