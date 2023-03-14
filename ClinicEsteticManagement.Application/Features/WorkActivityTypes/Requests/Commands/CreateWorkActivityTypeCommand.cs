using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Commands
{
    public class CreateWorkActivityTypeCommand : IRequest<Guid>
    {
        public CreateWorkActivityTypeDto dto { get; set; }
    }
}
