using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands
{
    public class CreateClinicalInformationCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public CreateClinicalInformationDto ClinicalInformationDto { get; set; }
    }
}
