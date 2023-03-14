using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public interface IGynecologicalConditions
    {
        public DateTime? PregnantDate { get; set; }
        public Guid? PregnancyTypeId { get; set; }
        public DateTime? BreastFeedDate { get; set; }
        public DateTime? MenstruatingDate { get; set; }
        public DateTime? MenopauseDate { get; set; }
        public int ChildrenQuantity { get; set; }
    }
}
