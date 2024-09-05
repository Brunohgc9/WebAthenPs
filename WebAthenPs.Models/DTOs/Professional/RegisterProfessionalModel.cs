using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional
{
    public class RegisterProfessionalModel
    {
        public string? ProfessionalType { get; set; }  // Corrigido para 'ProfessionalType'
        public string? UserId { get; set; }
    }
}
