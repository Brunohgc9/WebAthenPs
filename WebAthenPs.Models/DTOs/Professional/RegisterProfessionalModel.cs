using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional
{
    public class RegisterProfessionalModel
    {
        public List<string> ProfessionalTypes { get; set; } = new List<string>(); // Alterado para uma lista
        public string? UserId { get; set; }
    }
}
