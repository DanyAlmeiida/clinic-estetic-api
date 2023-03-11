using ClinicEsteticManagement.Application.DTOs.Client;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.Clients.Requests.Commands
{
    public class UpdateClientCommand : IRequest<UpdateClientDto>
    {
        public Guid Id { get; set; }
        public UpdateClientDto clientDto { get; set; }
    }
}
