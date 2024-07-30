using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAthenPs.API.Entities
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ConstructionType { get; set; }
        public string Status { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public string Address { get; set; }
        public string Neighborhood { get; set; }  // Bairro
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public decimal TotalArea { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }

        public ICollection<GenericProfessional> Professionals { get; set; } = new List<GenericProfessional>();
    }
}
