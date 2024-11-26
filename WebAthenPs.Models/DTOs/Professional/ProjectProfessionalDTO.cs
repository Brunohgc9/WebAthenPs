using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional
{
    public class ProjectProfessionalDTO
    {
        public int ProfessionalId { get; set; } // ID do Profissional
        public int ProjectId { get; set; } // ID do Projeto
        public GenericProfessionalDTO? Professional { get; set; } // Detalhes do Profissional
        public List<string> ContractedAs { get; set; } = new List<string>();
        public decimal? Salary { get; set; }
    }

}
