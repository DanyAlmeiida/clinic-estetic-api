using ClinicEsteticManagement.Application.DTOs.Common;

namespace ClinicEsteticManagement.Application.DTOs.Client
{
    public class UpdateClientDto : BaseDto, IClientDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string JobOccupation { get; set; }
        public string Observations { get; set; }

    }
}
