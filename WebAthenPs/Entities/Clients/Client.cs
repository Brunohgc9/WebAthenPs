using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Project;

namespace WebAthenPs.API.Entities.Clients
{
    public class Client
    {
        //Own Properties
        [Key]
        public int ClientId { get; set; }

        //Properties that will receive values from the ApplicationUser
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


        //Properties 1-N
        public ICollection<Projecty> Houses { get; set; } = new List<Projecty>();
        public ICollection<GenericProfessional> GenericProfessionals { get; set; }

    }
}
