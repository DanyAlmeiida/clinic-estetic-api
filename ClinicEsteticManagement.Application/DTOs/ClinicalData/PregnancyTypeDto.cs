using ClinicEsteticManagement.Application.DTOs.Common;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public class PregnancyTypeDto : BaseDto, IPregnancyType
    {
        public string Type { get; set; }
    }
}
