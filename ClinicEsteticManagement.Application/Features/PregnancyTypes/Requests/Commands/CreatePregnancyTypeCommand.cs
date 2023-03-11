using MediatR;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands
{
    public class CreatePregnancyTypeCommand : IRequest<Guid>
    {
        public string type { get; set; }
    }
}
