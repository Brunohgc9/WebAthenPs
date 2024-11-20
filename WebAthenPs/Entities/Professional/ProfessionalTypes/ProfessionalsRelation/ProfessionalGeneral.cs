using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation
{
    public class ProfessionalGeneral
    {
        public Guid Id { get; set; }
        public Guid? ProfessionalTypeId { get; set; }

        [ForeignKey("ProfessionalTypeId")]
        public GenericProfessionalProfessionalType? ProfessionalType { get; set; }
    }
}
