using ClinicEsteticManagement.Application.DTOs.Common;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public class GynecologicalConditionsDto : BaseDto, IGynecologicalConditions
    {
        public DateTime? PregnantDate { get; set; }
        public PregnancyTypeDto? PregnancyType { get; set; }
        public DateTime? BreastFeedDate { get; set; }
        public DateTime? MenstruatingDate { get; set; }
        public DateTime? MenopauseDate { get; set; }
        public int ChildrenQuantity { get; set; }
    }
}
