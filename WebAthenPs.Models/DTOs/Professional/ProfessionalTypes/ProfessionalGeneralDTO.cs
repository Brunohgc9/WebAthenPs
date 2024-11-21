using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional.ProfessionalTypes
{
    public class ProfessionalGeneralDTO
    {
        public Guid Id { get; set; }
        public Guid? ProfessionalTypeId { get; set; }

        [ForeignKey("ProfessionalTypeId")]
        public GenericProfessionalProfessionalTypeDTO? ProfessionalType { get; set; }
    }
}
