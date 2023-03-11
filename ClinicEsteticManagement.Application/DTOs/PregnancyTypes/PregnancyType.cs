using ClinicEsteticManagement.Application.DTOs.Common;

namespace ClinicEsteticManagement.Application.DTOs.PregnancyTypes
{
    public class PregnancyType : BaseDto, IPregnancyTypeDto
    {
        public string Type { get; set; }
    }
}
