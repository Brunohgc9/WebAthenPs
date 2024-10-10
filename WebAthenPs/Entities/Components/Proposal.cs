using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Project;

namespace WebAthenPs.API.Entities.Components
{
    public class Proposal
    {
        public Guid ProposalId { get; set; }
        public string ProposalMessage { get; set; }
        public decimal ProposalValue { get; set; }
        public string ProposalType { get; set;}
        public bool IsAccepted{ get; set; }

        public int ClientId {  get; set; }
        public int ProfessionalId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        [ForeignKey("ProfessionalId")]
        public GenericProfessional Professional { get; set; }

        public int? ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Projecty Project {  get; set; }

        public List<string> ToBeContractedAs { get; set; } = new List<string>();

    }
}
