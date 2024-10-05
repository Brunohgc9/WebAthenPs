using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.User
{
    public class UpdateUserModel
    {
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? UserType { get; set; } // Se você quiser permitir a atualização do tipo de usuário
    }
}
