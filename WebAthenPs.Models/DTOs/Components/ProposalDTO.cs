using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;

namespace WebAthenPs.Models.DTOs.Components
{
    public class ProposalDTO
    {
        public Guid ProposalId { get; set; }
        public string ProposalMessage { get; set; }
        public decimal ProposalValue { get; set; }
        public string ProposalType { get; set; }
        public bool IsAccepted { get; set; }

        public ClientDTO? Client { get; set; }

        public GenericProfessionalDTO? Professional { get; set; }
        public ProjectsDTO? Projects { get; set; }

        public List<string> ToBeContractedAs { get; set; } = new List<string>();

    }
}
