﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional
{
    public class GenericProfessionalDTO
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? ClientId { get; set; }
        public List<string> ProfessionalTypes { get; set; } = new List<string>(); // Alterado para uma lista
        public string? ClientName { get; set; }
    }
}
