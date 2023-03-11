using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands
{
    public class UpdateClinicalInformationCommand : IRequest<UpdateClinicalInformationDto>
    {
        public Guid ClientId { get; set; }
        public UpdateClinicalInformationDto UpdateClinicalInformationDto { get; set; }
    }
}
