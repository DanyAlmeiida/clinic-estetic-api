using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands
{
    public class CreatePregnancyTypeCommand : IRequest<Guid>
    {
        public CreatePregnancyTypeDto dto { get; set; }
    }
}
