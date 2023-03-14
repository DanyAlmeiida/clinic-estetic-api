using ClinicEsteticManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicEsteticManagement.Domain.ClinicalData
{
    public class GynecologicalConditions : BaseDomainEntity
    {
        [Column(TypeName = "Date")]
        public DateTime? PregnantDate { get; set; }
        public Guid? PregnancyTypeId { get; set; }
        public PregnancyType? PregnancyType { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? BreastFeedDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? MenstruatingDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? MenopauseDate { get; set; }
        public int ChildrenQuantity { get; set; }
    }
}
