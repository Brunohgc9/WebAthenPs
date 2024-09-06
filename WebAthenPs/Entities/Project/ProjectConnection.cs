using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional;

namespace WebAthenPs.API.Entities.Project
{
    public class ProjectConnection
    {
        [Key]
        public Guid ConnectionId { get; set; }

        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Projecty Projecty { get; set; }

        public int? ProfessionalId { get; set; }

        [ForeignKey("ProfessionalId")]
        public GenericProfessional? Professional { get; set; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
