using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands
{
    public class CreateGeneralDiseasesCommand : IRequest<Guid>
    {
        public Guid ClientId { get; set; }
        public CreateGeneralDiseasesDto GeneralDiseasesDto { get; set; }
    }
}
