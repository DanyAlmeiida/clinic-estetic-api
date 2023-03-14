using ClinicEsteticManagement.Application.DTOs.Common;

namespace ClinicEsteticManagement.Application.DTOs.WorkActivityTypes
{
    public class WorkActivityTypeDto : BaseDto, IWorkActivityTypeDto
    {
        public string? Type { get; set; }
    }
}
