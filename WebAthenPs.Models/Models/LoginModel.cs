using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        public string? Password { get; set; }

    }


}
