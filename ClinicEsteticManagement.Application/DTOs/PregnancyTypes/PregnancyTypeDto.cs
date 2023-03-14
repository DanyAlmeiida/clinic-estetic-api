using ClinicEsteticManagement.Application.DTOs.Common;

namespace ClinicEsteticManagement.Application.DTOs.PregnancyTypes
{
    public class PregnancyTypeDto : BaseDto, IPregnancyTypeDto
    {
        public string Type { get; set; }
    }
}
