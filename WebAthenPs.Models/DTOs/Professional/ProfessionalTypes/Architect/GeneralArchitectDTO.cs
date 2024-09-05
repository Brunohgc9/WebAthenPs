using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional.ProfessionalTypes.Architect
{
    public class GeneralArchitectDTO
    {
        public string name {  get; set; }
        public string email { get; set; }
        public int genericId { get; set; }
        public Guid ArchId { get; set; }
        public string RegistroConselho { get; set; }
        public string? Especialidade { get; set; }
    }
}
