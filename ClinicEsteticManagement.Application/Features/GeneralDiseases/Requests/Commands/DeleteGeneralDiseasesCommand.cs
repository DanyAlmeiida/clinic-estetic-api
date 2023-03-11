using MediatR;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands
{
    public class DeleteGeneralDiseasesCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
