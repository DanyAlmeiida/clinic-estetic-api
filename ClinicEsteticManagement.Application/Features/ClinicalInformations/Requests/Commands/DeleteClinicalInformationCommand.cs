using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands
{
    public class DeleteClinicalInformationCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
