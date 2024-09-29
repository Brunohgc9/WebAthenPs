using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.User
{
    public class LoginResult
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string ErrorMessage { get; set; }
        public bool? IsProfessional { get; set; }
        public bool NeedsProfessionalTypeRegistration { get; set; }
        public Guid UserId { get; set; }
    }

}
